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
    public class PIRA_NoC
    {
        [TestMethod]
        public void NoC_01Create()
        {
            string url = ConfigurationManager.AppSettings["url"];
            string file = ConfigurationManager.AppSettings["NOC"];
            string sheetName = ConfigurationManager.AppSettings["NOC_Create"];
            string path = ConfigurationManager.AppSettings["NOC_Path"];
            string subPath = ConfigurationManager.AppSettings["NOC_Path_Create"];

            Test_Method test = new Test_Method();

            test.executeTest(url, file, sheetName, path, subPath);
        }

        [TestMethod]
        public void NoC_02Update()
        {
            string url = ConfigurationManager.AppSettings["url"];
            string file = ConfigurationManager.AppSettings["NOC"];
            string sheetName = ConfigurationManager.AppSettings["NOC_Update"];
            string path = ConfigurationManager.AppSettings["NOC_Path"];
            string subPath = ConfigurationManager.AppSettings["NOC_Path_Update"];

            Test_Method test = new Test_Method();

            test.executeTest(url, file, sheetName, path, subPath);
        }

        [TestMethod]
        public void NoC_03Toggle()
        {

            string url = ConfigurationManager.AppSettings["url"];
            string file = ConfigurationManager.AppSettings["NOC"];
            string sheetName = ConfigurationManager.AppSettings["NOC_Toggle"];
            string path = ConfigurationManager.AppSettings["NOC_Path"];
            string subPath = ConfigurationManager.AppSettings["NOC_Path_Toggle"];

            Test_Method test = new Test_Method();

            test.executeTest(url, file, sheetName, path, subPath);
        
        }

        [TestMethod]
        public void NoC_04Delete()
        {
            string url = ConfigurationManager.AppSettings["url"];
            string file = ConfigurationManager.AppSettings["NOC"];
            string sheetName = ConfigurationManager.AppSettings["NOC_Delete"];
            string path = ConfigurationManager.AppSettings["NOC_Path"];
            string subPath = ConfigurationManager.AppSettings["NOC_Path_Delete"];

            Test_Method test = new Test_Method();

            test.executeTest(url, file, sheetName, path, subPath);
        }

        [TestCleanup]
        public void CleanTest()
        {


        }
    }
    
}
