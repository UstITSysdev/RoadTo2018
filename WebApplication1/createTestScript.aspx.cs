using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Configuration;
using MySql.Data.MySqlClient;
using System.Text;

namespace WebApplication1
{
    public partial class createTestScript : System.Web.UI.Page
    {
        MySqlConnection DBConnect = new MySqlConnection(ConfigurationManager.ConnectionStrings["connect"].ToString());


        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected string btnUploadClick()
        {
            HttpPostedFile file = Request.Files["fileUpload"];
            string path="";

            //check file was submitted
            if (file != null && file.ContentLength > 0)
            {
                string fname = Path.GetFileName(file.FileName);

                string directory = Path.Combine("~/AppData/", fname);

                file.SaveAs(Server.MapPath(directory));

               

                Response.Write(@"<script language='javascript'>alert('fname')</script>");

                path = directory;
               
            }
            else
            {
                Response.Write(@"<script language='javascript'>alert('error')</script>");
            }
            return path;
        }

        protected void addScript(object sender, EventArgs e)
        {

            string CommandText = "insert into scripts(projname,category,subcategory,testname,excelfile,sheetname) values(?projname,?category,?subcategory,?testname,?excelfile,?sheetname)";
            MySqlCommand cmd = new MySqlCommand(CommandText, DBConnect);

            string excelfile = btnUploadClick();

            cmd.Parameters.AddWithValue("?projname", scriptProjectName.Text);
            cmd.Parameters.AddWithValue("?category", category.Text);
            cmd.Parameters.AddWithValue("?subcategory", subCategory.Text);
            cmd.Parameters.AddWithValue("?testname", testName.Text);
            cmd.Parameters.AddWithValue("?excelfile", excelfile);
            cmd.Parameters.AddWithValue("?sheetname", sheetName.Text);


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