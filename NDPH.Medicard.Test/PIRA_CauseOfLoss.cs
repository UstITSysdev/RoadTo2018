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
    public class PIRA_CauseOfLoss
    {
        [TestMethod]
        public void CauseOfLoss_01Create()
        {
            string url = ConfigurationManager.AppSettings["url"];
            string file = ConfigurationManager.AppSettings["COL"];
            string sheetName = ConfigurationManager.AppSettings["COL_Create"];
            string path = ConfigurationManager.AppSettings["COL_Path"];
            string subPath = ConfigurationManager.AppSettings["COL_Path_Create"];

            Test_Method test = new Test_Method();

            test.executeTest(url, file, sheetName, path, subPath);

        }

        [TestMethod]
        public void CauseOfLoss_02Update()
        {
            string url = ConfigurationManager.AppSettings["url"];
            string file = ConfigurationManager.AppSettings["COL"];
            string sheetName = ConfigurationManager.AppSettings["COL_Update"];
            string path = ConfigurationManager.AppSettings["COL_Path"];
            string subPath = ConfigurationManager.AppSettings["COL_Path_Update"];

            Test_Method test = new Test_Method();

            test.executeTest(url, file, sheetName, path, subPath);
        }

        [TestMethod]
        public void CauseOfLoss_03Toggle()
        {
            string url = ConfigurationManager.AppSettings["url"];
            string file = ConfigurationManager.AppSettings["COL"];
            string sheetName = ConfigurationManager.AppSettings["COL_Toggle"];
            string path = ConfigurationManager.AppSettings["COL_Path"];
            string subPath = ConfigurationManager.AppSettings["COL_Path_Toggle"];

            Test_Method test = new Test_Method();

            test.executeTest(url, file, sheetName, path, subPath);
        }

        [TestMethod]
        public void CauseOfLoss_04Reorder()
        {
            string url = ConfigurationManager.AppSettings["url"];
            string file = ConfigurationManager.AppSettings["COL"];
            string sheetName = ConfigurationManager.AppSettings["COL_Reorder"];
            string path = ConfigurationManager.AppSettings["COL_Path"];
            string subPath = ConfigurationManager.AppSettings["COL_Path_Reorder"];

            Test_Method test = new Test_Method();

            test.executeTest(url, file, sheetName, path, subPath);
        }

        [TestMethod]
        public void CauseOfLoss_05Delete()
        {
            string url = ConfigurationManager.AppSettings["url"];
            string file = ConfigurationManager.AppSettings["COL"];
            string sheetName = ConfigurationManager.AppSettings["COL_Delete"];
            string path = ConfigurationManager.AppSettings["COL_Path"];
            string subPath = ConfigurationManager.AppSettings["COL_Path_Delete"];

            Test_Method test = new Test_Method();

            test.executeTest(url, file, sheetName, path, subPath);

        }
    }
}