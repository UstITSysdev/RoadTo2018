using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NDPH.AutomatedTestFramework;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using System.IO;
using OpenQA.Selenium.Chrome;
using System.Configuration;
using System.Windows.Forms;
using System.Threading;

namespace NDPH.SeleniumWrapper
{
    public class SeleniumBrowserAutomator : BaseBrowserAutomator
    {

        public SeleniumBrowserAutomator(DriverType driverType,string finalPath,string finalSubPath,string timeStamp)
        {
            this.driver = new DriverCreator().CreateDriver(driverType);
            this.finalPath = finalPath;
            this.finalSubPath = finalSubPath;
            this.timeStamp = timeStamp;

        }
            private IWebDriver driver;
            private string finalPath;
            private string finalSubPath;

            private string timeStamp;

            
            int error = 1;

        
         public void executeShot(string scenarioName, int stepNumber,int error,string msg,string imagePath)
         {

             Screenshot ss = ((ITakesScreenshot)driver).GetScreenshot();

             string screenshot = ss.AsBase64EncodedString;
             byte[] screenshotAsByteArray = ss.AsByteArray;
                 

             if (error != 1)
             {
                 ss.SaveAsFile(imagePath +"/"+ scenarioName + "-" + stepNumber + ".png", ScreenshotImageFormat.Png);
             }
             else 
             {
                 const int maxLength = 38;
                 msg = msg.Substring(0, maxLength);
                 ss.SaveAsFile(imagePath + "/ERROR-" + scenarioName + "-" + stepNumber + msg + ".png", ScreenshotImageFormat.Png);
                 
             }
             ss.ToString();
            
         }

         private void SubPath(string scenarioName, int stepNumber, int error, string msg)
         {
             

             if (Directory.Exists(finalSubPath))
             {
                 DatePath(scenarioName, stepNumber, error, msg);
             }
             else
             {
                 Directory.CreateDirectory(finalSubPath);
                 DatePath(scenarioName, stepNumber, error, msg);
             }
             
         }

         private void DatePath(string scenarioName, int stepNumber, int error, string msg)
         {


             if (Directory.Exists(timeStamp))
             {
                 string imagePath = System.IO.Path.Combine(timeStamp, "image");
                 Directory.CreateDirectory(imagePath);
                 executeShot(scenarioName, stepNumber, error, msg,imagePath);
             }
             else
             {
                 Directory.CreateDirectory(timeStamp);
                 string imagePath = System.IO.Path.Combine(timeStamp, "image");
                 Directory.CreateDirectory(imagePath);
                 executeShot(scenarioName, stepNumber, error, msg,imagePath);
             }

         }

         private void TextPath(string scenarioName, int stepNumber, string elementAttributeType, string elementAttributeName, string xpathExpression)
         {


             if (Directory.Exists(timeStamp))
             {
                 string textPath = System.IO.Path.Combine(timeStamp, "text");
                 Directory.CreateDirectory(textPath);
                 if (xpathExpression == null)
                 {
                     string input = driver.FindElement(new ElementFinder().RetrieveElement(elementAttributeType, elementAttributeName)).GetAttribute("value");
                     System.IO.File.WriteAllText(textPath + "/" + scenarioName + "-" + stepNumber + ".txt", input);
                 }
                 else 
                 {
                     string input = driver.FindElement(By.XPath(xpathExpression)).GetAttribute("value");
                     System.IO.File.WriteAllText(textPath + "/" + scenarioName + "-" + stepNumber + ".txt", input);
                 
                 }
             }
            

         }




         private void Direct(string scenarioName, int stepNumber, int error, string msg)
         {


             if (Directory.Exists(finalPath))
             {
                 SubPath(scenarioName, stepNumber, error, msg);
             }
             else
             {
                 Directory.CreateDirectory(finalPath);
                 SubPath(scenarioName, stepNumber, error, msg);
             }

         }
       


        #region Actions

        public override Boolean ClickButton(string elementAttributeType, string elementAttributeName,string scenarioName,int stepNumber,string filePath)
        {
            try
            {

                
                driver.FindElement(By.Name(elementAttributeName)).SendKeys(filePath);
                Direct(scenarioName, stepNumber,0,null);
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine("ClickButton Error: " + ex.ToString());
                Direct(scenarioName, stepNumber,error,ex.ToString());
                return false;
            }

        }

        public override Boolean EnterTextOnTextField(string elementAttributeType, string elementAttributeName, string textInput, string scenarioName, int stepNumber, string frameId, string xpathExpression)
        {
            try
            {

                if(frameId != null)
                {
                    driver.SwitchTo().Frame(frameId);
                }

                if(xpathExpression == null)
                {
                    driver.FindElement(new ElementFinder().RetrieveElement(elementAttributeType, elementAttributeName)).SendKeys(textInput);
                    
                    if (textInput.Length >= 50)
                    {
                        TextPath(scenarioName,stepNumber,elementAttributeType,elementAttributeName,xpathExpression);
                        //string scenarioName, int stepNumber, string elementAttributeType, string elementAttributeName
                    }       
                }
                else
                {
                    driver.FindElement(By.XPath(xpathExpression)).SendKeys(textInput);

                    if (textInput.Length >= 50)
                    {
                        TextPath(scenarioName, stepNumber, elementAttributeType, elementAttributeName,xpathExpression);
                    }
                }

                driver.SwitchTo().DefaultContent();
                Direct(scenarioName, stepNumber,0,null);
                return true;
            }
            catch (Exception ex)
            {
                Direct(scenarioName, stepNumber, error, ex.ToString());
                driver.SwitchTo().DefaultContent();
                Console.WriteLine("EnterTextOnTextField Error: " + ex.ToString());
                return false;
            }

        }

        //public override Boolean CheckNotificationBar(string xpathExpression,string scenarioName,int stepNumber)
        //{
        //    try
        //    {
        //        string trueText = driver.FindElement(By.XPath(xpathExpression)).Text;
        //        return true;
        //    }
        //    catch (Exception ex)
        //    {
        //        Console.WriteLine("CheckNotificationBar Error: " + ex.ToString());
        //        return false;
        //    }
        //}

        public override Boolean CheckText(string frameId, string xpathExpression, string scenarioName, int stepNumber)
        {
            try
            {
                if (frameId != null)
                {
                    driver.SwitchTo().Frame(frameId);
                    driver.FindElement(By.XPath(xpathExpression));
                    driver.SwitchTo().DefaultContent();
                }
                else
                {
                    string trueText = driver.FindElement(By.XPath(xpathExpression)).Text;
                }
                Direct(scenarioName, stepNumber,0,null);
                return true;
                
            }
            catch (Exception ex)
            {
                Direct(scenarioName, stepNumber, error, ex.ToString());
                driver.SwitchTo().DefaultContent();
                Console.WriteLine("CheckText Error: " + ex.ToString());
                Console.WriteLine("xpathExpression: " + "'" + xpathExpression + "'");
                Console.WriteLine("Frame: " + "'" + frameId + "'");


                return false;
            }

        }

        public override Boolean ClearTextField(string elementAttributeType, string elementAttributeName, string frameId, string xpathExpression,string scenarioName,int stepNumber)
        {
            try
            {

                if (frameId != null)
                {
                    driver.SwitchTo().Frame(frameId);
                }

                if (xpathExpression == null)
                {
                    driver.FindElement(new ElementFinder().RetrieveElement(elementAttributeType, elementAttributeName)).Clear();
                }
                else 
                {
                    driver.FindElement(By.XPath(xpathExpression)).Clear();
                }
                driver.SwitchTo().DefaultContent();
                Direct(scenarioName, stepNumber,0,null);
                return true;
            }
            catch (Exception ex)
            {
                Direct(scenarioName, stepNumber, error, ex.ToString());
                driver.SwitchTo().DefaultContent();
                Console.WriteLine("ClearTextField Error: " + ex.ToString());
                return false;
            }

        }

        public override Boolean SubmitData(string elementAttributeType, string elementAttributeName,string scenarioName,int stepNumber)
        {
            try
            {
                driver.FindElement(new ElementFinder().RetrieveElement(elementAttributeType, elementAttributeName)).Submit();
                Direct(scenarioName, stepNumber,0,null);
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine("SubmitData Error: " + ex.ToString());
                Direct(scenarioName, stepNumber, error, ex.ToString());
                return false;
            }

        }

        public override Boolean StartBrowser(string url)
        {
            try
            {
                driver.Navigate().GoToUrl(url);
                driver.Manage().Window.Maximize();
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine("StartBrowser Error: " + ex.ToString());
                return false;
            }

        }

        public override Boolean CloseBrowser()
        {
            try
            {
                driver.Close();
                driver.Quit();
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine("CloseBrowser Error: " + ex.ToString());
                return false;
            }
        }

        public override bool MouseMove(string frameId, string xpathExpression,string scenarioName,int stepNumber)
        {
            try
            {
                if (frameId != null)
                {
                    driver.SwitchTo().Frame(frameId);
                }

                ILocatable locatableItem = (ILocatable)this.driver.FindElement(By.XPath(xpathExpression));
                IMouse mouse = ((IHasInputDevices)this.driver).Mouse;
                mouse.MouseMove(locatableItem.Coordinates);

                driver.SwitchTo().DefaultContent();
                Direct(scenarioName, stepNumber,0,null);
                return true;
            }
            catch (Exception ex)
            {
                driver.SwitchTo().DefaultContent();
                Console.WriteLine("ClearTextField Error: " + ex.ToString());
                Direct(scenarioName, stepNumber, error, ex.ToString());
                return false;
            }
        }

        #region code reference
        //public override bool ExecuteXpath(string frameId, string xpath)
        //{
        //    try
        //    {
        //        driver.SwitchTo().Frame(frameId);
        //        driver.FindElement(By.XPath(xpath)).Click();
        //        driver.SwitchTo().DefaultContent();
        //        return true;

        //        return true;
        //    }
        //    catch (Exception ex)
        //    {
        //        Console.WriteLine("ExecuteXpath Error: " + ex.ToString());
        //        return false;
        //    }
        //}
        #endregion

        public override bool ClickGridItems(string frameId, string xpathExpression,string scenarioName, int stepNumber)
        {
            try
            {
                if (frameId != null)
                {
                    driver.SwitchTo().Frame(frameId);
                    driver.FindElement(By.XPath(xpathExpression)).Click();
                    driver.SwitchTo().DefaultContent();
                    Direct(scenarioName, stepNumber, 0, null);
                    return true;
                }
                else 
                {
                    ILocatable locatableItem = (ILocatable)this.driver.FindElement(By.XPath(xpathExpression));
                    IMouse mouse = ((IHasInputDevices)this.driver).Mouse;
                    mouse.Click(locatableItem.Coordinates);
                    Direct(scenarioName, stepNumber,0,null);
                    return true;
                }


            }
            catch (Exception ex)
            {
                Console.WriteLine("MouseClick Error: " + ex.ToString());
                Direct(scenarioName, stepNumber, error, ex.ToString());
                return false;
            }
        }
        //public override bool MouseClick(string xpathExpression, string scenarioName, int stepNumber)
        //{
        //    try
        //    {
        //        #region javascript executor reference
        //        //IJavaScriptExecutor executor = (IJavaScriptExecutor)driver;
        //        //executor.ExecuteScript("myFunction()");
        //        //executor.ExecuteScript("_common_getWindowParent()._popup_launchJqueryEntrySelenium('/Common/Product/Edit/f7572d54-6cfd-e611-a2ac-680715066188', 'Edit', 'Edit Product', 550, 400, null, 'DepartmentGrid', false)");
        //        //executor.ExecuteScript("observeDivMaster()");
        //        #endregion
        //        SendKeys.SendWait(@"");
        //        SendKeys.SendWait(@"{Enter}");    

        //        return true;
        //    }
        //    catch (Exception ex)
        //    {
        //        Console.WriteLine("ClearTextField Error: " + ex.ToString());
        //        executeShot(scenarioName, stepNumber, error, ex.ToString());
        //        return false;
        //    }
        //}

        public override bool Close(string xpathExpression,string scenarioName,int stepNumber)
        {

            try
            {
                driver.Close();
                driver.Quit();
                Direct(scenarioName, stepNumber,0,null);
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine("CloseBrowser Error: " + ex.ToString());
                Direct(scenarioName, stepNumber, error, ex.ToString());
                return false;
            }
        }

        //public override bool mousedown (string xpathexpression,string scenarioname,int stepnumber)
        //{
        //    try
        //    {

        //        string type = configurationmanager.appsettings["type"];
        //        string name1 = configurationmanager.appsettings["name"];
        //        string value1= configurationmanager.appsettings["value"];

        //        string name2 = configurationmanager.appsettings["name2"];
        //        string value2 = configurationmanager.appsettings["value2"];

        //        entertextontextfield(type,name1,value1,scenarioname,stepnumber,null,null);
        //        entertextontextfield(type, name2, value2, scenarioname, stepnumber, null, null);

        //        //string elementattributetype, string elementattributename, string textinput,
        //        //string scenarioname, int stepnumber, string frameid, string xpathexpression


        //        //ijavascriptexecutor executor = (ijavascriptexecutor)driver;
        //        //executor.executescript("window.scrollby(0,60)", "");


        //        //ijavascriptexecutor executor = ((ijavascriptexecutor)driver);
        //        //executor.executescript("window.scrollto(0, document.body.scrollheight)");

        //        direct(scenarioname, stepnumber,0,null);
        //        return true;
        //    }
        //    catch (exception ex)
        //    {
        //        console.writeline("cleartextfield error: " + ex.tostring());
        //        direct(scenarioname, stepnumber, error, ex.tostring());
        //        return false;
        //    }
        //}

        public override bool MouseUp(string xpathExpression, string scenarioName, int stepNumber)
        {
            try
            {
                IJavaScriptExecutor executor = ((IJavaScriptExecutor)driver);
                executor.ExecuteScript("window.scrollTo(0, -document.body.scrollHeight)");
                Direct(scenarioName, stepNumber,0,null);
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine("ClearTextField Error: " + ex.ToString());
                Direct(scenarioName, stepNumber, error, ex.ToString());
                return false;
            }
        }

        public override bool MouseDown(string xpathExpression, string scenarioName, int stepNumber)
        {
            throw new NotImplementedException();
        }

        #endregion
    }

}