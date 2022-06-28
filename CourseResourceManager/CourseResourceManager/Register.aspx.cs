using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Drawing;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;


namespace CourseResourceManager
{
    public partial class Register : System.Web.UI.Page
    {
        private bool UserNameIselgal = false;
        private bool PsdIselgal = false;
        private bool CanRegister = false;
        private bool PsdTwoIselgal = false;

        protected void Page_Load(object sender, EventArgs e)
        {

        }


        protected void linkToLogin_Click(object sender, EventArgs e)
        {
            Response.Redirect("Login.aspx");
        }

        protected void btnRegister_Click(object sender, EventArgs e)
        {
            Session["User"] = rUserNameText.Text;
            Session["Psd"] = rPsdText.Text;

            string connStr = ConfigurationManager.ConnectionStrings["UserDBConnectionString"].ToString();
            SqlConnection conn = new SqlConnection(connStr);


            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("select count(*) from UserInfo where UId=@UId", conn);
                cmd.Parameters.Add("@UId", SqlDbType.Char);
                cmd.Parameters[0].Value = Session["User"];
                int count = (int)cmd.ExecuteScalar();

                if (count > 0)
                {

                    Response.Write("<script>alert('用户名已存在!')</script>");
                }
                else
                {

                    CanRegister = true;
                }
            }
            catch
            {
                Response.Write("检测重名异常");
            }

            finally
            {
                conn.Close();
            }

            if ((CanRegister && UserNameIselgal) && (PsdIselgal && PsdTwoIselgal))
            {
                try
                {
                    conn.Open();
                    string strIns = "insert into UserInfo(UId, Psd) values(@UId, @Psd)";
                    SqlCommand cmd = new SqlCommand(strIns, conn);
                    cmd.Parameters.Add("@UId", SqlDbType.NChar);
                    cmd.Parameters.Add("@Psd", SqlDbType.NChar);

                    cmd.Parameters["@UId"].Value = Session["User"];
                    cmd.Parameters["@Psd"].Value = Session["Psd"];

                    cmd.ExecuteNonQuery();
                }
                catch
                {
                    Response.Write("注册异常");
                }
                finally
                {
                    conn.Close();

                }
            }

            if ((CanRegister && UserNameIselgal) && (PsdIselgal && PsdTwoIselgal))
            {
                Session["CurrentUser"] = rUserNameText.Text;
                Response.Redirect("Home.aspx");
            }

        }

        protected void CustomValidator1_ServerValidate(object source, System.Web.UI.WebControls.ServerValidateEventArgs args)
        {
            if (rUserNameText.Text.Equals("用户名"))
            {
                CustomValidator1.ErrorMessage = "*用户名为空";
                args.IsValid = false;
            }
            else if (System.Text.RegularExpressions.Regex.IsMatch(rUserNameText.Text, "^[0-9a-zA-Z]+$") &&
                    rUserNameText.Text.Length > 5 && rUserNameText.Text.Length < 11)
            {
                args.IsValid = true;
                UserNameIselgal = true;
            }
            else
            {
                CustomValidator1.ErrorMessage = "*用户名由6~10位数字和字母构成";
                args.IsValid = false;
            }


        }

        protected void CustomValidator2_ServerValidate(object source, System.Web.UI.WebControls.ServerValidateEventArgs args)
        {
            if (rPsdText.Text.Equals("密码"))
            {
                CustomValidator2.ErrorMessage = "*密码为空";
                args.IsValid = false;
            }

            else if (System.Text.RegularExpressions.Regex.IsMatch(rPsdText.Text, "^[0-9a-zA-Z]+$") &&
              rPsdText.Text.Length > 4)
            {
                args.IsValid = true;
                PsdIselgal = true;
            }
            else
            {
                CustomValidator2.ErrorMessage = "*密码由全数字和字母构成且不少于5位";
                args.IsValid = false;
            }
        }

        protected void CustomValidator3_ServerValidate(object source, System.Web.UI.WebControls.ServerValidateEventArgs args)
        {
            if (rrPsdText.Text.Equals("") || rrPsdText.Text.Equals("确认密码"))
            {
                args.IsValid = false;
                CustomValidator3.ErrorMessage = "*确认密码为空";
                PsdTwoIselgal = false;
            }
            else if (!rrPsdText.Text.Equals(rPsdText.Text))
            {
                args.IsValid = false;
                CustomValidator3.ErrorMessage = "*两次密码不一致";
                PsdTwoIselgal = false;
            }
            else
            {
                args.IsValid = true;
                PsdTwoIselgal = true;
            }
        }
    }
}