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
    public partial class Registration : System.Web.UI.Page
    {
        public CLASS_CONNECT cn = new CLASS_CONNECT();
        protected void Page_Load(object sender, EventArgs e)
        {
        }

        void clear()
        {
            TXT_NAME.Text = "";
            TXT_NUMBER.Text = "";
            TXT_ADDRESS.Text = "";
            RBTN_MALE.Checked = false;
            RBTN_FEMALE.Checked = false;
            CB1.Checked = false;
            CB2.Checked = false;
            CB3.Checked = false;
            TXT_UN.Text = "";
            TXT_PASS.Text = "";
            TXT_CPASS.Text = "";
        }

        protected void BTN_REG_Click(object sender, EventArgs e)
        {
            string gen = "";
            string hob = "";
            string dt = DateTime.Now.ToString();

            if (RBTN_MALE.Text == "Male")
            {
                gen = "Male";
            }
            else
            {
                gen = "Female";
            }

            if (CB1.Checked == true)
            {
                hob = "basketball";
                if (CB2.Checked == true)
                {
                    hob = "basketball, WWE";
                    if (CB3.Checked == true)
                    {
                        hob = "basketball, WWE, volleyball";
                    }
                    
                }
                if (CB3.Checked == true)
                {
                    hob = "basketball, volleyball";
                }
                
            }

            if (CB2.Checked == true)
            {
                hob = "WWE";
                if (CB1.Checked == true)
                {
                    hob = "basketball, WWE";
                    if (CB3.Checked == true)
                    {
                        hob = "basketball, WWE, volleyball";
                    }

                }
                if (CB3.Checked == true)
                {
                    hob = "WWE, volleyball";
                }

            }

            if (CB3.Checked == true)
            {
                hob = "volleyball";
                if (CB1.Checked == true)
                {
                    hob = "basketball, volleyball";
                    if (CB2.Checked == true)
                    {
                        hob = "basketball, WWE, volleyball";
                    }

                }
                if (CB2.Checked == true)
                {
                    hob = "WWE, volleyball";
                }

            }



            try
            {

                SqlCommand check_User_Name = new SqlCommand("SELECT COUNT(*) FROM TBL_REG WHERE Username = @user", cn.con);
                check_User_Name.Parameters.AddWithValue("@user", TXT_UN.Text);

                int UserExist = (int)check_User_Name.ExecuteScalar();

                if (UserExist > 0)
                {
                    LBL_ERROR.Text = "User Already Exist";
                    DIV_SUCCESS.Visible = false;
                    DIV_ERROR.Visible = true;
                }
                else
                {
                    SqlCommand cmd = new SqlCommand("insert into TBL_REG values (@Name,@Number,@Address,@Gender,@Hobbies,@Username,@Password,@LastLogin)", cn.con);
                    cmd.Parameters.AddWithValue("@Name", TXT_NAME.Text);
                    cmd.Parameters.AddWithValue("@Number", TXT_NUMBER.Text);
                    cmd.Parameters.AddWithValue("@Address", TXT_ADDRESS.Text);
                    cmd.Parameters.AddWithValue("@Gender", gen);
                    cmd.Parameters.AddWithValue("@Hobbies", hob);
                    cmd.Parameters.AddWithValue("@Username", TXT_UN.Text);
                    cmd.Parameters.AddWithValue("@Password", TXT_PASS.Text);
                    cmd.Parameters.AddWithValue("@LastLogin", dt);
                    int i = cmd.ExecuteNonQuery();
                    if (i > 0)
                    {
                        LBL_SUCCESS.Text = "User Register successfully...";
                        DIV_SUCCESS.Visible = true;
                        DIV_ERROR.Visible = false;
                        clear();
                    }
                }

            } 

            catch (Exception ex)
            {
                LBL_ERROR.Text = ex.Message;
                DIV_ERROR.Visible = true;
                DIV_SUCCESS.Visible = false;
                clear();
            }
        }

        protected void BTN_CANCLE_Click(object sender, EventArgs e)
        {
            clear();
        }

        protected void BTN_LOGIN_Click(object sender, EventArgs e)
        {
            Response.Redirect("Login.aspx");
        }
    }
}