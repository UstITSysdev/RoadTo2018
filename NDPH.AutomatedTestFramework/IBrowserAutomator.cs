using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NDPH.AutomatedTestFramework
{
    public interface IBrowserAutomator
    {
        Boolean ExecuteStep(Step step);
        Boolean EnterTextOnTextField(string elementAttributeType, string elementAttributeValue, string textInput, string scenarioName, int stepNumber, string frameId, string xpathExpression);
        Boolean ClickButton(string elementAttributeType, string elementAttributeValue,string scenarioName,int stepNumber,string filePath);
        Boolean ClearTextField(string elementAttributeType, string elementAttributeValue, string frameId, string xpathExpression,string scenarioName,int stepNumber);
        Boolean SubmitData(string elementAttributeType, string elementAttributeValue,string scenarioName,int stepNumber);
        Boolean StartBrowser(string url);
        Boolean CloseBrowser();
        Boolean MouseMove(string frameId, string xpathExpression,string scenarioName,int stepNumber);
        //Boolean MouseClick(string xpathExpression,string scenarioName, int stepNumber);
        Boolean Close(string xpathExpression,string scenarioName,int stepNumber);
        Boolean MouseDown(string xpathExpression, string scenarioName, int stepNumber);
        Boolean MouseUp(string xpathExpression, string scenarioName, int stepNumber);
    }
}
