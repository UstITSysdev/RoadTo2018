using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class Main2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            if (Session["Logged"].Equals("No"))
            {
                Response.Redirect("Login.aspx");

            }
            else
            {
                Response.Write(@"<script language='javascript'>alert('Session not null')</script>");

            }





        }

        protected void Unnamed_Click(object sender, EventArgs e)
        {

        }
    }
}