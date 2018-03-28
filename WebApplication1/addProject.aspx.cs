using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Configuration;
using MySql.Data.MySqlClient;

namespace WebApplication1
{
    public partial class addProject : System.Web.UI.Page
    {
        MySqlConnection DBConnect = new MySqlConnection(ConfigurationManager.ConnectionStrings["connect"].ToString());

        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void createProject(object sender, EventArgs e)
        {

            string CommandText = "insert into projects(projname,url) values(?projname,?url)";
            MySqlCommand cmd = new MySqlCommand(CommandText, DBConnect);
            cmd.Parameters.AddWithValue("?projname", projNameCreate.Text);
            cmd.Parameters.AddWithValue("?url", URL.Text);

            cmd.Connection.Open();
            int result = cmd.ExecuteNonQuery();
            if (result > 0)
            {
                Response.Write(@"<script language='javascript'>alert('Project Added Successfully')</script>");
            }
            else
            {
                Response.Write(@"<script language='javascript'>alert('pisting yawa')</script>");
            }
            cmd.Connection.Close();
            DBConnect.Close();



        }
    }
}