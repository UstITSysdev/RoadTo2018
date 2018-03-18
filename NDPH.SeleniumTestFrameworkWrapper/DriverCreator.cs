using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.IE;
using OpenQA.Selenium.Edge;

namespace NDPH.SeleniumWrapper
{
    public class DriverCreator
    {
        public OpenQA.Selenium.Remote.RemoteWebDriver CreateDriver(DriverType driverType)
        {
            if (driverType == DriverType.IE)
            {
                return new InternetExplorerDriver();

            }
            else if (driverType == DriverType.CHROME)
            {
                return new ChromeDriver();

            }
            else if (driverType == DriverType.FIREFOX)
            {
                return new FirefoxDriver();
            }
            else if (driverType == DriverType.EDGE)
            {
                //string driverPath = @"D:\my files\office files\Projects\NDPH.AutomatedTestFramework\NDPH.Medicard.Test\bin\Debug";
                //EdgeDriverService service;
                //service.
                return new EdgeDriver();
            }
            return null;
        }

    }
}
