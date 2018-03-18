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
    public class PIRA_VAT
    {

        

        //Testi Method Creation begins
        [TestMethod]
        public void VAT_01Create()
        {
            string url = ConfigurationManager.AppSettings["url"];
            string file = ConfigurationManager.AppSettings["VAT"];
            string sheetName = ConfigurationManager.AppSettings["VAT_Create"];
            string path = ConfigurationManager.AppSettings["VAT_Path"];
            string subPath = ConfigurationManager.AppSettings["VAT_Path_Create"];

            Test_Method test = new Test_Method();

            test.executeTest(url, file, sheetName, path, subPath);
        }
        
        
        [TestMethod]
        public void VAT_02Update()
        {

            string url = ConfigurationManager.AppSettings["url"];
            string file = ConfigurationManager.AppSettings["VAT"];
            string sheetName = ConfigurationManager.AppSettings["VAT_Edit"];
            string path = ConfigurationManager.AppSettings["VAT_Path"];
            string subPath = ConfigurationManager.AppSettings["VAT_Path_Update"];

            Test_Method test = new Test_Method();

            test.executeTest(url, file, sheetName, path, subPath);
        }

        [TestMethod]
        public void VAT_03Toggle()
        {
            string url = ConfigurationManager.AppSettings["url"];
            string file = ConfigurationManager.AppSettings["VAT"];
            string sheetName = ConfigurationManager.AppSettings["VAT_Toggle"];
            string path = ConfigurationManager.AppSettings["VAT_Path"];
            string subPath = ConfigurationManager.AppSettings["VAT_Path_Toggle"];

            Test_Method test = new Test_Method();

            test.executeTest(url, file, sheetName, path, subPath);
        }

        [TestMethod]
        public void VAT_04Delete()
        {

            string url = ConfigurationManager.AppSettings["url"];
            string file = ConfigurationManager.AppSettings["VAT"];
            string sheetName = ConfigurationManager.AppSettings["VAT_Delete"];
            string path = ConfigurationManager.AppSettings["VAT_Path"];
            string subPath = ConfigurationManager.AppSettings["VAT_Path_Delete"];

            Test_Method test = new Test_Method();

            test.executeTest(url, file, sheetName, path, subPath);
        }



    }


}