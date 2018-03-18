using System;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NDPH.SeleniumWrapper;
using NDPH.AutomatedTestFramework;
using NDPH.AutomatedTestFramework.ScenarioReader;
using System.Xml;
using System.Configuration;

namespace NDPH.Medicard.Test
{
    [TestClass]
    public class PIRA_REGISTRATION
    {
        [TestMethod]
        public void REGISTRATION()
        {
            string url = ConfigurationManager.AppSettings["url"];
            string file = ConfigurationManager.AppSettings["Company_Register"];
            string sheetName = ConfigurationManager.AppSettings["CR_Registration"];
            string path = ConfigurationManager.AppSettings["CR_Path"];
            string subPath = ConfigurationManager.AppSettings["CR_Path_Register"];

            Test_Method test = new Test_Method();

            test.executeTest(url, file, sheetName, path, subPath);
        }

        [TestMethod]
        public void REGISTER()
        {
            string url = ConfigurationManager.AppSettings["url"];
            string file = ConfigurationManager.AppSettings["User_Register"];
            string sheetName = ConfigurationManager.AppSettings["UR_Registration"];
            string path = ConfigurationManager.AppSettings["UR_Path"];
            string subPath = ConfigurationManager.AppSettings["UR_Path_Register"];

            Test_Method test = new Test_Method();

            test.executeTest(url, file, sheetName, path, subPath);
        }
    }


}