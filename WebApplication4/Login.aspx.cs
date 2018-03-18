using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using MySql.Data.MySqlClient;
using System.Configuration;

namespace WebApplication4
{
    public partial class Login : System.Web.UI.Page
    {
        MySqlConnection DBConnect = new MySqlConnection(ConfigurationManager.ConnectionStrings["connect"].ToString());
        MySqlCommand cmd = new MySqlCommand();
        MySqlDataAdapter adapter = new MySqlDataAdapter();
        DataSet data = new DataSet();

        protected void Page_Load(object sender, EventArgs e)
        {

            //DBConnection_funct();
            
        }

        public void DBConnection_funct()
        {

            MySqlConnection DBConnection = new MySqlConnection(ConfigurationManager.ConnectionStrings["connect"].ToString());

            try
            {
                DBConnect.Open();
                
            }
            catch (Exception e)
            {
                Response.Write(e);
            } 

        }


        protected void Login_Click(Object sender, EventArgs e)
        {

            if (uname.Text != null || pass.Text != null)
            {
                String query = "select * from accounts where username =?uname AND password =?pass";
                MySqlCommand cmd = new MySqlCommand(query, DBConnect);
                cmd.Connection.Open();
                cmd.Prepare();
                cmd.Parameters.AddWithValue("?uname",uname.Text);
                cmd.Parameters.AddWithValue("?pass", pass.Text);
                cmd.ExecuteNonQuery();
                adapter.SelectCommand = cmd;
                adapter.Fill(data, "reg");
                if (data.Tables[0].Rows.Count > 0)
                {

                    Response.Write(@"<script language='javascript'>alert('Login successfully')</script>");
                    Response.Redirect("https://www.google.com");
                }
                else
                {
                    Response.Write(@"<script language='javascript'>alert('Wrong username or password')</script>");
                }
                cmd.Connection.Close();
               
            }
            else
            {
                Response.Write(@"<script language='javascript'>alert('Wrong username or password')</script>");
            }
        }

    }
}