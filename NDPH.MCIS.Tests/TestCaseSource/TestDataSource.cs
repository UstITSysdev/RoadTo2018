using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
namespace NDPH.MCIS.Tests
{
    public class TestDataSource
    {
        private static string Url
        {
            get
            {
                return ConfigurationManager.AppSettings["url"];
            }
        }

        private static string FileName
        {
            get
            {
                return ConfigurationManager.AppSettings["filename"];
            }
        }

        private const string VAT_WORKSHEET = "VAT_CREATE";
        public const string FAIL = "fail";
        public const string SUCCEED = "succeed";
        
        public static object[] ScenarioSource =
        {
            new object[] {Url,FileName,VAT_WORKSHEET},
            new object[]{}
        };

    }
}
