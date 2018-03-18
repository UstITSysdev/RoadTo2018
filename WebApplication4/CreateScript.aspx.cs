using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using NDPH.Medicard.Test;
using System.Configuration;

namespace WebApplication4
{
    public partial class CreateScript : System.Web.UI.Page
    {
        public void Page_Load(object sender, EventArgs e)
        {
            Test_Method test = new Test_Method();

            //test.executeTest();
           
        }
    }
}