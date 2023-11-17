using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace FundRaiser
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void submitbtn_Click(object sender, EventArgs e)
        {
            try
            {
                DB D = new DB();
                string qry = "select * from users join Roles on Users.RoleID=Roles.RoleID where Email='" + username.Text + "' and Password='" + Password.Text + "'";

                DataTable dt = new DataTable();
                dt = D.FetchData(qry);

                if (dt.Rows.Count > 0)
                {
                    Session["USERID"] = dt.Rows[0]["UserID"].ToString();
                    Session["Name"] = dt.Rows[0]["UserName"].ToString();
                    Session["Role"] = dt.Rows[0]["Role"].ToString();
                    Session["Email"] = dt.Rows[0]["Email"].ToString();


                    Response.Redirect("Default.aspx");

                }
                else
                {
                    ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('Invalid Login')", true);

                }
            }
            catch(Exception ex)
            {

            }
        }
    }
}