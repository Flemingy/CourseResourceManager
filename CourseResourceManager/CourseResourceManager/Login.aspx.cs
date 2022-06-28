using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace CourseResourceManager
{
    public partial class Login : System.Web.UI.Page
    {
        protected void LinkButton1_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Register.aspx");
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string connStr = ConfigurationManager.ConnectionStrings["UserDBConnectionString"].ToString();
            SqlConnection conn = new SqlConnection(connStr);

            try
            {


                conn.Open();
                SqlCommand cmd = new SqlCommand("select count(*) from UserInfo where UId=@UId and Psd=@Psd", conn);
                cmd.Parameters.Add("@UId", SqlDbType.Char);
                cmd.Parameters.Add("@Psd", SqlDbType.Char);
                cmd.Parameters[0].Value = TextBox1.Text;
                cmd.Parameters[1].Value = TextBox2.Text;
                int count = (int)cmd.ExecuteScalar();
                if (count == 1)
                {

                    Session["CurrentUser"] = TextBox1.Text;
                    Response.Redirect("./Home.aspx");


                }
                else
                {
                    Response.Write("<script>alert('用户名或密码错误')</script>");
                }
            }
            catch
            {
                Response.Write("<script>alert('登录异常')</script>");
            }

            finally
            {
                conn.Close();
            }
        }

        protected void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        protected void TextBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}