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
    public partial class Home : System.Web.UI.Page
    {
        CLASS_CONNECT cn = new CLASS_CONNECT();
        protected void Page_Load(object sender, EventArgs e)
        {
            
            if (!IsPostBack)
            {
                if (Session["validated"] == null)
                {
                    Response.Redirect("Login.aspx");
                } else
                {
                    SqlCommand cmd = new SqlCommand("update TBL_REG set LastLogin = '" + DateTime.Now.ToString() + "' where Id = '"+ Session["Id"].ToString() + "' ", cn.con);
                    int i = cmd.ExecuteNonQuery();
                    if(i>0)
                    {
                        LBL_NAME.Text = Session["Name"].ToString();
                        LBL_DT.Text = Session["LastLogin"].ToString();
                    }
                    else
                    {
                        Session["validated"] = null;
                        Response.Redirect("Login.aspx");
                    }
                    
                }
                
            }
        }

        protected void BTN_LOGOUT_Click(object sender, EventArgs e)
        {
            Session["validated"] = null;
            Response.Redirect("Login.aspx");
        }
    }
}