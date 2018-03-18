using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NDPH.AutomatedTestFramework
{
    public abstract class BaseBrowserAutomator : IBrowserAutomator
    {
        public BaseBrowserAutomator()
        {
            PopulateActionsList();
        }

        private Dictionary<string, System.Func<string, string, string,int,Boolean>> actionsListWithNoValueInput = new Dictionary<string, Func<string, string, string,int,bool>>();
        private Dictionary<string, System.Func<string, string, string, string, string, int, Boolean>> actionsListWithXpathExpressionAndFrameIdNoValueInput = new Dictionary<string, Func<string, string, string, string, string, int, bool>>();
        private Dictionary<string, System.Func<string, string, string, string, int, string, string, Boolean>> actionsListWithValueInput = new Dictionary<string, Func<string, string, string, string, int, string, string, bool>>();
        private Dictionary<string, System.Func<string, string, int, Boolean>> actionsListWithRequiredXPathExpression = new Dictionary<string,Func<string, string, int, bool>>();
        private Dictionary<string, System.Func<string, string,string,int, Boolean>> actionsListWithRequiredXPathExpressionAndFrameId = new Dictionary<string, Func<string, string,string,int, bool>>();
        private Dictionary<string, System.Func<string, string, string, int, Boolean>> actionsListWithRequiredXPathExpressionAndFrameIdAndDetails = new Dictionary<string, Func<string, string, string, int, bool>>();
        private Dictionary<string, System.Func<string, string, string, int,string, Boolean>> actionsListWithPath = new Dictionary<string, Func<string, string, string, int,string, bool>>();
        
        private void PopulateActionsList()
        {
            actionsListWithPath.Add("clickbutton", new Func<string, string,string,int,string,bool>(this.ClickButton));
            actionsListWithXpathExpressionAndFrameIdNoValueInput.Add("cleartextfield", new Func<string, string, string, string,string,int, bool>(this.ClearTextField));
            actionsListWithNoValueInput.Add("submitdata", new Func<string, string,string,int, bool>(this.SubmitData));

            actionsListWithValueInput.Add("entertextontextfield", new Func<string, string, string, string, int, string, string, bool>(this.EnterTextOnTextField));

           // actionsListWithRequiredXPathExpression.Add("mouseclick", new Func<string,string,int, bool>(this.MouseClick));
            actionsListWithRequiredXPathExpression.Add("close", new Func<string, string,int, bool>(this.Close));
            actionsListWithRequiredXPathExpression.Add("login", new Func<string,string,int, bool>(this.MouseDown));
            actionsListWithRequiredXPathExpression.Add("mouseup", new Func<string, string, int, bool>(this.MouseUp));
           
            

            actionsListWithRequiredXPathExpressionAndFrameId.Add("mousemove", new Func<string, string,string,int, bool>(this.MouseMove));
            actionsListWithRequiredXPathExpressionAndFrameIdAndDetails.Add("verify", new Func<string, string, string, int, bool>(this.CheckText));
            actionsListWithRequiredXPathExpressionAndFrameId.Add("clickgriditems", new Func<string, string,string,int, bool>(this.ClickGridItems));
        }

        public abstract bool ClearTextField(string elementAttributeType, string elementAttributeValue, string frameId, string xpathExpression,string scanarioName, int stepNumber);

        public abstract bool ClickButton(string elementAttributeType, string elementAttributeValue,string scenarioName,int stepNumber,string filePath);

        public abstract bool CloseBrowser();

        //public abstract bool ExecuteXpath(string frameId, string xpath);

        public abstract bool EnterTextOnTextField(string elementAttributeType, string elementAttributeValue, string textInput, string scenarioName, int stepNumber, string frameId, string xpathExpression);

        public abstract bool CheckText(string xpathExpression, string frameId,string scenarioName, int stepNumber);

        //public abstract bool CheckNotificationBar(string xpathExpression);

        public virtual bool ExecuteStep(Step step)
        {
            bool returnValue = false;
            Func<string, string,string,int, bool> dActionsListWithNoInputValue = null;
            Func<string, string, string, string,string,int, bool> dActionsListWithXpathExpressionAndFrameIdNoValueInput = null;
            Func<string, string, string, string, int, string, string, bool> dActionsListWithValueInput = null;
            Func<string, string, int, bool> dActionsListWithRequiredXPathExpression = null;
            Func<string, string,string,int, bool> dActionsListWithRequiredXPathExpressionAndFrameId = null;
            Func<string, string, string, int, bool> dActionsListWithRequiredXPathExpressionAndFrameIdAndDetails = null;
            Func<string, string, string, int,string, bool> dActionsListWithFilePath = null;
            string actionName = step.ActionName.ToLower();

            if (actionsListWithNoValueInput.TryGetValue(actionName, out dActionsListWithNoInputValue))
            {
                returnValue = dActionsListWithNoInputValue.Invoke(step.ElementInformation.ElementType, step.ElementInformation.ElementName,step.ScenarioName,step.StepNumber);
            }
            else if (actionsListWithValueInput.TryGetValue(actionName, out dActionsListWithValueInput))
            {
                returnValue = dActionsListWithValueInput.Invoke(step.ElementInformation.ElementType, step.ElementInformation.ElementName, step.ElementInformation.ElementValue, step.ScenarioName, step.StepNumber, step.FrameId, step.XpathExpression);
            }
            else if (actionsListWithRequiredXPathExpression.TryGetValue(actionName, out dActionsListWithRequiredXPathExpression))
            {
                returnValue = dActionsListWithRequiredXPathExpression.Invoke(step.XpathExpression, step.ScenarioName, step.StepNumber);
            }
            else if (actionsListWithRequiredXPathExpressionAndFrameId.TryGetValue(actionName, out dActionsListWithRequiredXPathExpressionAndFrameId))
            {
                returnValue = dActionsListWithRequiredXPathExpressionAndFrameId.Invoke(step.FrameId, step.XpathExpression,step.ScenarioName,step.StepNumber);
            }
            else if (actionsListWithRequiredXPathExpressionAndFrameIdAndDetails.TryGetValue(actionName, out dActionsListWithRequiredXPathExpressionAndFrameIdAndDetails))
            {
                returnValue = dActionsListWithRequiredXPathExpressionAndFrameIdAndDetails.Invoke(step.FrameId, step.XpathExpression, step.ScenarioName, step.StepNumber);
            }
            else if (actionsListWithXpathExpressionAndFrameIdNoValueInput.TryGetValue(actionName, out dActionsListWithXpathExpressionAndFrameIdNoValueInput))
            {
                returnValue = dActionsListWithXpathExpressionAndFrameIdNoValueInput.Invoke(step.ElementInformation.ElementType, step.ElementInformation.ElementName, step.FrameId, step.XpathExpression,step.ScenarioName,step.StepNumber);
            } else if (actionsListWithXpathExpressionAndFrameIdNoValueInput.TryGetValue(actionName, out dActionsListWithXpathExpressionAndFrameIdNoValueInput))
            {
                returnValue = dActionsListWithXpathExpressionAndFrameIdNoValueInput.Invoke(step.ElementInformation.ElementType, step.ElementInformation.ElementName, step.FrameId, step.XpathExpression,step.ScenarioName,step.StepNumber);
            }
            else if (actionsListWithPath.TryGetValue(actionName, out dActionsListWithFilePath))
                {
                    returnValue = dActionsListWithFilePath.Invoke(step.ElementInformation.ElementType, step.ElementInformation.ElementName, step.ScenarioName, step.StepNumber,step.FilePath);
                }
            //Waiting time after a step has been performed. This is needed as elements cannot be retrieved if they aren't still loaded in the browser
            System.Threading.Thread.Sleep(step.WaitingTime);
            return returnValue;
        }

        public abstract bool ClickGridItems(string frameId, string xpathExpression, string scenarioName, int stepNumber);

        //public abstract bool MouseClick(string xpathExpression,string scenarioName, int stepNumber);

        public abstract bool Close(string xpathExpression,string scenarioName,int stepNumber);

        public abstract bool MouseDown(string xpathExpression, string scenarioName, int stepNumber);

        public abstract bool MouseMove(string frameId, string xpathExpression, string scenarioName, int stepNumber);

        public abstract bool MouseUp(string xpathExpression, string scenarioName, int stepNumber);

        public abstract bool StartBrowser(string url);

        public abstract bool SubmitData(string elementAttributeType, string elementAttributeValue, string scenarioName, int stepNumber);
    }
}
