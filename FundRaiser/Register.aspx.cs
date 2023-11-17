using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace FundRaiser
{
    public partial class Register : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void registerbtn_Click(object sender, EventArgs e)
        {
            try
            {
                DB D = new DB();
                string checkqry = "insert into Users(UserName,Email,Password,RoleID,FirstName,LastName) " +
                    "values('" + firstname.Text + " " + lastname.Text + "','" + email.Text + "','" + Password.Text + "',1,'" + firstname.Text + "','" + lastname.Text + "')";

                if(Password.Text.Length < 8)
                {
                    ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('Password must be atleast 8 letters')", true);
                    return;
                }

                if(cpassword.Text != Password.Text)
                {
                    ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('Please enter correct password in confirm password')", true);
                    return;
                }

                bool specialcharcheck = false;
                string specialCh = @"%!@#$%^&*()?/>.<,:;'\|}]{[_~`+=-" + "\"";
                char[] specialChar = specialCh.ToCharArray();
                foreach (char ch in specialChar)
                {
                    if (Password.Text.Contains(ch))
                    {
                        specialcharcheck = true;
                    }
                        
                }

              
                if (!specialcharcheck)
                {
                    ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('Password must contain atleast 1 special character')", true);
                    return;
                }

                bool containsInt = Password.Text.ToString().Any(char.IsDigit);

               
                if (!containsInt)
                {
                    ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('Password must contain atleast 1 number)", true);
                    return;
                }

                if (D.InsertData(checkqry))
                {
                    ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('Success !!!! Please login ')", true);

                }
                else
                {
                    ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('Failed Please try again')", true);

                }
            }
            catch(Exception ex)
            {

            }
        }
    }
}