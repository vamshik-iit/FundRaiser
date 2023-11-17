using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace FundRaiser
{
    public partial class ManageAccess : System.Web.UI.Page
    {
        DB D = new DB();

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void FetchCurrentRole_Click(object sender, EventArgs e)
        {
            try
            {
                string query = "select UserID,Email,Role from Users join Roles on Roles.RoleID=Users.RoleID where UserID=" + EmailUserID.Text + " or Email='" + EmailUserID.Text + "'";
                DataTable dt = new DataTable();
                dt=D.FetchData(query);
                if(dt.Rows.Count > 0)
                {
                    UserRole.Text = "Current Role - " + dt.Rows[0]["Role"].ToString();
                }
            }
            catch(Exception ex)
            {

            }
        }

        protected void UpdateRole_Click(object sender, EventArgs e)
        {
            try
            {
                string query = "update users set RoleID=" + NewRole.SelectedIndex.ToString() + " where UserID=" + EmailUserID.Text + " or Email='" + EmailUserID.Text + "'";

                if (D.InsertData(query))
                {
                    ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('Updated')", true);
                }
                else
                {
                    ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('Failed')", true);
                }
            }
            catch (Exception ex)
            {

            }
        }
    }
}