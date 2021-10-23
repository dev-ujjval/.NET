using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;

namespace CRUD
{
    public partial class Login : System.Web.UI.Page
    {
        CLASS_CONNECT cn = new CLASS_CONNECT();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void BTN_LOGIN_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("select * from TBL_REG where Username = @username and Password = @password", cn.con);
                cmd.Parameters.AddWithValue("@username", TXT_UN.Text);
                cmd.Parameters.AddWithValue("@password", TXT_PASS.Text);

                DataSet ds = new DataSet();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(ds);

                bool loginSuccessful = ((ds.Tables.Count > 0) && (ds.Tables[0].Rows.Count > 0));

                if (loginSuccessful)
                {
                    string name = ds.Tables[0].Rows[0].Field<string>("Name");
                    object LL = ds.Tables[0].Rows[0].Field<object>("LastLogin");
                    int id = ds.Tables[0].Rows[0].Field<int>("Id");
                    Session["Id"] = id;
                    Session["Name"] = name;
                    Session["LastLogin"] = LL;
                    Session["validated"] = true;
                    Response.Redirect("Home.aspx");
                }
                else
                {
                    LBL_ERROR.Text = "Invalid username or password";
                    DIV_ERROR.Visible = true;
                    DIV_SUCCESS.Visible = false;
                }
            }
            catch (Exception ex)
            {
                LBL_ERROR.Text = ex.Message;
                DIV_ERROR.Visible = true;
                DIV_SUCCESS.Visible = false;
            }
           
        }

        protected void BTN_CANCLE_Click(object sender, EventArgs e)
        {
            TXT_UN.Text = "";
            TXT_PASS.Text = "";
        }
    }
}