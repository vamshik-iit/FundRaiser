using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
namespace FundRaiser
{
    public partial class EditProfile : System.Web.UI.Page
    {
        DataTable dt = new DataTable();
        string querystring = "";
        DB db = new DB();

        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                dt = db.FetchData("select * from users where USERID=" + Session["USERID"].ToString() + "");

                if(dt.Rows.Count > 0)
                {
                    firstname.Text = dt.Rows[0]["firstname"].ToString();
                    lastname.Text = dt.Rows[0]["LastName"].ToString();
                  
                }

                dt = db.FetchData("select * from UserAddress where USERID=" + Session["USERID"].ToString() + "");

                if (dt.Rows.Count > 0)
                {
                    address.Text = dt.Rows[0]["address"].ToString();
                    zipcode.Text = dt.Rows[0]["zipcode"].ToString();
                }

                dt = db.FetchData("select * from RecieverBankDetails where USERID=" + Session["USERID"].ToString() + "");

                if (dt.Rows.Count > 0)
                {
                    bankacc.Text = dt.Rows[0]["BankAccNumber"].ToString();
                    routingno.Text = dt.Rows[0]["RoutingNumber"].ToString();
                    mobile.Text = dt.Rows[0]["MobileNumber"].ToString();
                   
                }



            }
            catch(Exception ex)
            {

            }
        }

        protected void savedetails_Click(object sender, EventArgs e)
        {
            try
            {
                dt = db.FetchData("select * from users where USERID=" + Session["USERID"].ToString() + "");

                if (dt.Rows.Count > 0)
                {
                   
                    querystring = "update users set firstname='" + firstname.Text + "',LastName='" + lastname.Text + "' where UserID=" + Session["USERID"].ToString() + "";
                    if (!db.InsertData(querystring))
                    {
                        ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('Error in user name, Please try again')", true);
                        return;
                    }
                }
               

                dt = db.FetchData("select * from UserAddress where USERID=" + Session["USERID"].ToString() + "");

                if (dt.Rows.Count > 0)
                {
                   
                    querystring = "update UserAddress set address='" + address.Text + "',zipcode=" + zipcode.Text + " where UserID=" + Session["USERID"].ToString() + "";
                    if (!db.InsertData(querystring))
                    {
                        ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('Error in address update, Please try again')", true);
                        return;
                    }

                }
                else
                {
                    querystring = "insert into UserAddress(UserID,address,zipcode) values(" + Session["USERID"].ToString() + ",'" + address.Text + "'," + zipcode.Text + ")";
                    if (!db.InsertData(querystring))
                    {
                        ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('Error in address insert, Please try again')", true);
                        return;
                    }

                }
                dt = db.FetchData("select * from RecieverBankDetails where USERID=" + Session["USERID"].ToString() + "");

                if (dt.Rows.Count > 0)
                {
                   
                    querystring = "update RecieverBankDetails set BankAccNumber=" + bankacc.Text + ",RoutingNumber=" + routingno.Text + ",MobileNumber=" + mobile.Text + ",UpdatedOn=getdate(),UpdatedBy=" + Session["USERID"].ToString() + " where UserID=" + Session["USERID"].ToString() + "";
                    if (!db.InsertData(querystring))
                    {
                        ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('Error in bank details update, Please try again')", true);
                        return;
                    }
                }
                else
                {
                    querystring = "insert into RecieverBankDetails(UserID,BankAccNumber,RoutingNumber,MobileNumber,UpdatedBy) " +
                        "values(" + Session["USERID"].ToString() + "," + bankacc.Text + "," + routingno.Text + "," + mobile.Text + "," + Session["USERID"].ToString() + ")";
                    if (!db.InsertData(querystring))
                    {
                        ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('Error in bank details insert, Please try again')", true);
                        return;
                    }
                }
            }
            catch (Exception ex)
            {

            }
        }
    }
}