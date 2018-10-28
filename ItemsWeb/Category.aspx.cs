using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ItemsWeb
{
    public partial class Category : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Save_Click(object sender, EventArgs e)
        {
            if (FileUpload1.HasFile)
            {
                string FileName = Path.GetFileName(FileUpload1.PostedFile.FileName);

                //Save files to disk
                FileUpload1.SaveAs(Server.MapPath("ItemsImages/" + FileName));

                //Add Entry to DataBase
                String strConnString = System.Configuration.ConfigurationManager
                    .ConnectionStrings["conString"].ConnectionString;
                SqlConnection con = new SqlConnection(strConnString);
                string strQuery = "insert into Categories (category_nameAr, category_nameEn,category_image)" +
                    " values(@Ar,@En, @FilePath)";
                SqlCommand cmd = new SqlCommand(strQuery);
                cmd.Parameters.AddWithValue("@Ar", cat_nameAr.Text);
                cmd.Parameters.AddWithValue("@En", cat_nameEn.Text);
                cmd.Parameters.AddWithValue("@FilePath", "ItemsImages/" + FileName);
                cmd.CommandType = CommandType.Text;
                cmd.Connection = con;
                try
                {
                    con.Open();
                    cmd.ExecuteNonQuery();
                    cat_nameAr.Text = "";
                    cat_nameEn.Text = "";
                    ErrorMessage.Text = "Insert Successfully";
                }
                catch (Exception ex)
                {
                    //Response.Write(ex.Message);
                    ErrorMessage.Text = ex.Message;
                }
                finally
                {
                    con.Close();
                    con.Dispose();
                }
            }
            else
            {
                ErrorMessage.Text = "Choose a Picture!";
            }
        }
    }
}