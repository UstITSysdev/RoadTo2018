using System;
using System.Linq;
using System.Xml;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NDPH.SeleniumWrapper;
using NDPH.AutomatedTestFramework;
using NDPH.AutomatedTestFramework.ScenarioReader;
using System.Configuration;

namespace NDPH.Medicard.Test
{
    [TestClass]
    public class PIRA_Body
    {
        [TestMethod]
        public void Body_01Create()
        {
            string url = ConfigurationManager.AppSettings["url"];
            string file = ConfigurationManager.AppSettings["Body"];
            string sheetName = ConfigurationManager.AppSettings["Body_Create"];
            string path = ConfigurationManager.AppSettings["Body_Path"];
            string subPath = ConfigurationManager.AppSettings["Body_Path_Create"];

            Test_Method test = new Test_Method();

            test.executeTest(url, file, sheetName,path,subPath);
        }

        [TestMethod]
        public void Body_02Update()
        {
            string url = ConfigurationManager.AppSettings["url"];
            string file = ConfigurationManager.AppSettings["Body"];
            string sheetName = ConfigurationManager.AppSettings["Body_Update"];
            string path = ConfigurationManager.AppSettings["Body_Path"];
            string subPath = ConfigurationManager.AppSettings["Body_Path_Update"];

            Test_Method test = new Test_Method();

            test.executeTest(url, file, sheetName, path, subPath);
        }

        [TestMethod]
        public void Body_03Toggle()
        {
            string url = ConfigurationManager.AppSettings["url"];
            string file = ConfigurationManager.AppSettings["Body"];
            string sheetName = ConfigurationManager.AppSettings["Body_Toggle"];
            string path = ConfigurationManager.AppSettings["Body_Path"];
            string subPath = ConfigurationManager.AppSettings["Body_Path_Toggle"];

            Test_Method test = new Test_Method();

            test.executeTest(url, file, sheetName, path, subPath);
           
        }

        [TestMethod]
        public void Body_04Delete()
        {
            string url = ConfigurationManager.AppSettings["url"];
            string file = ConfigurationManager.AppSettings["Body"];
            string sheetName = ConfigurationManager.AppSettings["Body_Delete"];
            string path = ConfigurationManager.AppSettings["Body_Path"];
            string subPath = ConfigurationManager.AppSettings["Body_Path_Delete"];

            Test_Method test = new Test_Method();

            test.executeTest(url, file, sheetName, path, subPath);
        }

        [TestMethod]
        public void marvs()
        {
            string url = "http://toast.webstarterz.com";
            string file = ConfigurationManager.AppSettings["Body"];
            string sheetName = "Sheet1";
            string path = ConfigurationManager.AppSettings["Body_Path"];
            string subPath = ConfigurationManager.AppSettings["Body_Path_Create"];

            Test_Method test = new Test_Method();

            test.executeTest(url, file, sheetName, path, subPath);
        }

        [TestCleanup]
        public void CleanTest()
        {


        }
    }
    
}
