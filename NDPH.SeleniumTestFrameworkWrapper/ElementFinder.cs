using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
namespace NDPH.SeleniumWrapper
{
    public class ElementFinder
    {
        public By RetrieveElementByXPath(string elementTag, string elementAttribute, string elementAttributeValue)
        {
            try
            {
                string xPath = string.Format("//{0}[contains(text(),'Order')]", elementTag, elementAttribute, elementAttributeValue);
                By returnValue = By.XPath(xPath);
                return returnValue;
            }
            catch (Exception ex)
            {
                Console.WriteLine("RetrieveElement Error: " + ex.ToString());
                return null;
            }
        }
        public By RetrieveElement(string elementAttributeType, string elementAttributeName)
        {
            try
            {
                By returnValue = null;
                switch (elementAttributeType.ToLower())
                {
                    case "id":
                        returnValue = By.Id(elementAttributeName); 
                        break;
                    case "name":
                        returnValue = By.Name(elementAttributeName);
                        break;
                }
                return returnValue;
            }
            catch(Exception ex)
            {
                Console.WriteLine("RetrieveElement Error: " + ex.ToString());
                return null;
            }
        }
    }
}
