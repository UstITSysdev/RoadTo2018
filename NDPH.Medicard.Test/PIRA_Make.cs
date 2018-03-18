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
    public class PIRA_Make
    {
        [TestMethod]
        public void Make_01Create()
        {
            string url = ConfigurationManager.AppSettings["url"];
            string file = ConfigurationManager.AppSettings["Make"];
            string sheetName = ConfigurationManager.AppSettings["Make_Create"];
            string path = ConfigurationManager.AppSettings["Make_Path"];
            string subPath = ConfigurationManager.AppSettings["Make_Path_Create"];

            Test_Method test = new Test_Method();

            test.executeTest(url, file, sheetName, path, subPath);
        }

        [TestMethod]
        public void Make_02Update()
        {
            string url = ConfigurationManager.AppSettings["url"];
            string file = ConfigurationManager.AppSettings["Make"];
            string sheetName = ConfigurationManager.AppSettings["Make_Update"];
            string path = ConfigurationManager.AppSettings["Make_Path"];
            string subPath = ConfigurationManager.AppSettings["Make_Path_Update"];

            Test_Method test = new Test_Method();

            test.executeTest(url, file, sheetName, path, subPath);
        }

        [TestMethod]
        public void Make_03Toggle()
        {
            string url = ConfigurationManager.AppSettings["url"];
            string file = ConfigurationManager.AppSettings["Make"];
            string sheetName = ConfigurationManager.AppSettings["Make_Toggle"];
            string path = ConfigurationManager.AppSettings["Make_Path"];
            string subPath = ConfigurationManager.AppSettings["Make_Path_Toggle"];

            Test_Method test = new Test_Method();

            test.executeTest(url, file, sheetName, path, subPath);
        }

        [TestMethod]
        public void Make_04Delete()
        {
            string url = ConfigurationManager.AppSettings["url"];
            string file = ConfigurationManager.AppSettings["Make"];
            string sheetName = ConfigurationManager.AppSettings["Make_Delete"];
            string path = ConfigurationManager.AppSettings["Make_Path"];
            string subPath = ConfigurationManager.AppSettings["Make_Path_Delete"];

            Test_Method test = new Test_Method();

            test.executeTest(url, file, sheetName, path, subPath);
        }

        [TestCleanup]
        public void CleanTest()
        {


        }

    }
}