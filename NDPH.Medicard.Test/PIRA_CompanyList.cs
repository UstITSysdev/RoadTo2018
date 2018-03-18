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
    public class PIRA_CompanyList
    {
        [TestMethod]
        public void CompanyList_01Create()
        {
            string url = ConfigurationManager.AppSettings["url"];
            string file = ConfigurationManager.AppSettings["Company_List"];
            string sheetName = ConfigurationManager.AppSettings["CL_Create"];
            string path = ConfigurationManager.AppSettings["Company_Path"];
            string subPath = ConfigurationManager.AppSettings["CL_Path_Create"];

            Test_Method test = new Test_Method();

            test.executeTest(url, file, sheetName, path, subPath);
        }

        [TestMethod]
        public void CompanyList_02Update()
        {
            string url = ConfigurationManager.AppSettings["url"];
            string file = ConfigurationManager.AppSettings["Company_List"];
            string sheetName = ConfigurationManager.AppSettings["CL_Update"];
            string path = ConfigurationManager.AppSettings["Company_Path"];
            string subPath = ConfigurationManager.AppSettings["CL_Path_Update"];

            Test_Method test = new Test_Method();

            test.executeTest(url, file, sheetName, path, subPath);
        
        }

        [TestMethod]
        public void CompanyList_03Toggle()
        {
            string url = ConfigurationManager.AppSettings["url"];
            string file = ConfigurationManager.AppSettings["Company_List"];
            string sheetName = ConfigurationManager.AppSettings["CL_Toggle"];
            string path = ConfigurationManager.AppSettings["Company_Path"];
            string subPath = ConfigurationManager.AppSettings["CL_Path_Toggle"];

            Test_Method test = new Test_Method();

            test.executeTest(url, file, sheetName, path, subPath);
        }

        [TestMethod]
        public void CompanyList_04Delete()
        {
            string url = ConfigurationManager.AppSettings["url"];
            string file = ConfigurationManager.AppSettings["Company_List"];
            string sheetName = ConfigurationManager.AppSettings["CL_Delete"];
            string path = ConfigurationManager.AppSettings["Company_Path"];
            string subPath = ConfigurationManager.AppSettings["CL_Path_Delete"];

            Test_Method test = new Test_Method();

            test.executeTest(url, file, sheetName, path, subPath);
        }

        [TestCleanup]
        public void CleanTest()
        {


        }
    }
    
}
