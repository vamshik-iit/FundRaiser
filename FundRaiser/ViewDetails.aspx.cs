using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
namespace FundRaiser
{
    public partial class ViewDetails : System.Web.UI.Page
    {
        string PostID = "";
        DB D = new DB();
        protected void Page_Load(object sender, EventArgs e)
        {
            PostID = (Request.QueryString["PostID"]).ToString().Trim();
            if (!IsPostBack)
            {
               
                LoadData();
            }
        }

        private void LoadData()
        {
            try
            {

                string query = "select * from FundPosts join Users on FundPosts.PostedBy=Users.UserID where PostID=" + PostID + "";

                DataTable dt = new DataTable();
                dt = D.FetchData(query);
                title.Text = dt.Rows[0]["FundDescription"].ToString();
               
                emotionalstory.Text = dt.Rows[0]["EmotionalStory"].ToString();
                postedby.Text = dt.Rows[0]["UserName"].ToString();
                amountrequired.Text = dt.Rows[0]["AmountRequired"].ToString();
                postedon.Text = dt.Rows[0]["PostedOn"].ToString();
             
                string fileName = dt.Rows[0]["ImagePath"].ToString();


                string imagePath = Server.MapPath("~/images/");


                string imageFullPath = imagePath + fileName;


                uploadedimage.ImageUrl = "~/images/" + fileName;


                query = "select coalesce(sum(DonatedAmount),0) as AmountCollected from Donations where PostID=" + PostID + "";
                dt = D.FetchData(query);
                amountcollected.Text = dt.Rows[0]["AmountCollected"].ToString();


            }
            catch (Exception ex)
            {

            }
        }

        protected void Donate_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(amountdonate.Text))
                {
                    ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('Please enter amount to donate')", true);
                    return;
                }


                if (string.IsNullOrEmpty(confirmamountdonate.Text))
                {
                    ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('Please confirm amount to donate')", true);
                    return;
                }


                if (amountdonate.Text == confirmamountdonate.Text)
                {
                    string query = "INSERT INTO [dbo].[Donations] ([PostID],[DonatedBy],[DonatedAmount],[DonationStatus],[DonatedOn]) " +
                        " VALUES(" + PostID + "," + Session["USERID"].ToString() + "," + amountdonate.Text + ",'Success',getdate())";

                    if (D.InsertData(query))
                    {
                        ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('Success')", true);
                    }

                }



            }
            catch (Exception ex)
            {

            }
        }
    }
}