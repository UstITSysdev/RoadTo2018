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
    public class PIRA_VehicleType
    {
        [TestMethod]
        public void VehicleType_01Create()
        {
            string url = ConfigurationManager.AppSettings["url"];
            string file = ConfigurationManager.AppSettings["Vehicle_Type"];
            string sheetName = ConfigurationManager.AppSettings["VT_Create"];
            string path = ConfigurationManager.AppSettings["VT_Path"];
            string subPath = ConfigurationManager.AppSettings["VT_Path_Create"];

            Test_Method test = new Test_Method();

            test.executeTest(url, file, sheetName, path, subPath);
        }

        [TestMethod]
        public void VehicleType_02Update()
        {
            string url = ConfigurationManager.AppSettings["url"];
            string file = ConfigurationManager.AppSettings["Vehicle_Type"];
            string sheetName = ConfigurationManager.AppSettings["VT_Update"];
            string path = ConfigurationManager.AppSettings["VT_Path"];
            string subPath = ConfigurationManager.AppSettings["VT_Path_Update"];

            Test_Method test = new Test_Method();

            test.executeTest(url, file, sheetName, path, subPath);
        
        }

        //[TestMethod]
        //public void VehicleType_03Toggle()
        //{
        //    string url = ConfigurationManager.AppSettings["url"];
        //    string file = ConfigurationManager.AppSettings["Vehicle_Type"];
        //    string sheetName = ConfigurationManager.AppSettings["VT_Toggle"];

        //    Test_Method test = new Test_Method();
        //    test.executeTest(url, file, sheetName);
        //}

        [TestMethod]
        public void VehicleType_04Delete()
        {

            string url = ConfigurationManager.AppSettings["url"];
            string file = ConfigurationManager.AppSettings["Vehicle_Type"];
            string sheetName = ConfigurationManager.AppSettings["VT_Delete"];
            string path = ConfigurationManager.AppSettings["VT_Path"];
            string subPath = ConfigurationManager.AppSettings["VT_Path_Delete"];

            Test_Method test = new Test_Method();

            test.executeTest(url, file, sheetName, path, subPath);
        
        }

    }


}