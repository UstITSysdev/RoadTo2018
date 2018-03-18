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
    public class PIRA_Model
    {
        [TestMethod]
        public void Model_01Create()
        {
            string url = ConfigurationManager.AppSettings["url"];
            string file = ConfigurationManager.AppSettings["Model"];
            string sheetName = ConfigurationManager.AppSettings["Model_Create"];
            string path = ConfigurationManager.AppSettings["Model_Path"];
            string subPath = ConfigurationManager.AppSettings["Model_Path_Create"];

            Test_Method test = new Test_Method();

            test.executeTest(url, file, sheetName, path, subPath);
        }

        [TestMethod]
        public void Model_02Update()
        {
            string url = ConfigurationManager.AppSettings["url"];
            string file = ConfigurationManager.AppSettings["Model"];
            string sheetName = ConfigurationManager.AppSettings["Model_Update"];
            string path = ConfigurationManager.AppSettings["Model_Path"];
            string subPath = ConfigurationManager.AppSettings["Model_Path_Update"];

            Test_Method test = new Test_Method();

            test.executeTest(url, file, sheetName, path, subPath);
        }

        [TestMethod]
        public void Model_03Toggle()
        {
            string url = ConfigurationManager.AppSettings["url"];
            string file = ConfigurationManager.AppSettings["Model"];
            string sheetName = ConfigurationManager.AppSettings["Model_Toggle"];
            string path = ConfigurationManager.AppSettings["Model_Path"];
            string subPath = ConfigurationManager.AppSettings["Model_Path_Toggle"];

            Test_Method test = new Test_Method();

            test.executeTest(url, file, sheetName, path, subPath);
        }

        [TestMethod]
        public void Model_04Delete()
        {
            string url = ConfigurationManager.AppSettings["url"];
            string file = ConfigurationManager.AppSettings["Model"];
            string sheetName = ConfigurationManager.AppSettings["Model_Delete"];
            string path = ConfigurationManager.AppSettings["Model_Path"];
            string subPath = ConfigurationManager.AppSettings["Model_Path_Delete"];

            Test_Method test = new Test_Method();

            test.executeTest(url, file, sheetName, path, subPath);
        }

        [TestCleanup]
        public void CleanTest()
        {


        }

    }
}