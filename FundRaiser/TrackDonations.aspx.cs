using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace FundRaiser
{
    public partial class TrackDonations : System.Web.UI.Page
    {
        DB D = new DB();
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                if (!IsPostBack)
                {
                    string query="";

                    if (Session["Role"].ToString() == "Admin")
                    {
                        query = "select distinct PostID from FundPosts where IsActive=1";
                    }
                    else
                    {
                        query = "select distinct PostID from FundPosts where IsActive=1 and PostedBy = " + Session["USERID"].ToString() + " ";
                    }



                    DataTable dt = new DataTable();
                    dt = D.FetchData(query);

                    fundid.Items.Insert(0, "---- Select Fund Request ID ----");
                    for (int i = 0; i < dt.Rows.Count; i++)
                    {

                        fundid.Items.Insert(i + 1, dt.Rows[i]["PostID"].ToString());
                    }

                }
            }
            catch(Exception ex)
            {

            }
        }

      



        protected void OnPaging(object sender, GridViewPageEventArgs e)
        {
            try
            {
                GridView1.PageIndex = e.NewPageIndex;
                GridView1.DataBind();
                GridView2.PageIndex = e.NewPageIndex;
                GridView2.DataBind();
            }
            catch (Exception ex)
            {

            }

        }

        protected void fundid_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if(fundid.SelectedIndex != 0)
                {
                    string query = "select PostID,FundDescription,Type,AmountRequired,PostedOn,IsActive,IsFeatured,EmotionalStory,Title,UserName " +
                       "from FundPosts join Users on FundPosts.PostedBy = Users.UserID join FundTypes on FundTypes.TypeID = FundPosts.FundType " +
                       " where IsActive = 1 and PostID=" + fundid.SelectedValue + "";

                    DataTable dt = new DataTable();
                    dt = D.FetchData(query);
                    GridView1.DataSource = dt;
                    GridView1.DataBind();



                    query = "select PostID,DonatedAmount,DonationStatus,DonatedOn,UserName from Donations join Users on Donations.DonatedBy=Users.UserID " +
                        "where PostID=" + fundid.SelectedValue + "";

                    dt = D.FetchData(query);
                    GridView2.DataSource = dt;
                    GridView2.DataBind();
                }
                
            }
            catch(Exception ex)
            {

            }
        }
    }
}