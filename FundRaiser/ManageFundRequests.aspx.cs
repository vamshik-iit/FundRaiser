using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace FundRaiser
{
    public partial class ManageFundRequests : System.Web.UI.Page
    {
        DB D = new DB();
        protected void Page_Load(object sender, EventArgs e)
        {

            try
            {
                if (!IsPostBack)
                {
                    string query = "select PostID,FundDescription,Type,AmountRequired,PostedOn,IsActive,IsFeatured,EmotionalStory,Title,UserName " +
                        "from FundPosts join Users on FundPosts.PostedBy = Users.UserID join FundTypes on FundTypes.TypeID = FundPosts.FundType " +
                        " where IsActive = 1";

                    DataTable dt = new DataTable();
                    dt=D.FetchData(query);
                    GridView1.DataSource = dt;
                    GridView1.DataBind();
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
            }
            catch (Exception ex)
            {

            }

        }




        protected void Deletion_Click(object sender, EventArgs e)
        {
            try
            {
                Button btn = (Button)sender;
                string PostID = btn.CommandArgument[0].ToString();
              
             

                string query = "Update FundPosts SET IsActive=0 WHERE PostID=" + PostID + "";

                if (D.InsertData(query))
                {
                    ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('Success')", true);
                }
                else
                {
                    ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('Failed, Please try again')", true);
                }
                DataTable dt = new DataTable();

                query = "select PostID,FundDescription,Type,AmountRequired,PostedOn,IsActive,IsFeatured,EmotionalStory,Title,UserName " +
                      "from FundPosts join Users on FundPosts.PostedBy = Users.UserID join FundTypes on FundTypes.TypeID = FundPosts.FundType " +
                      "where IsActive = 1";
                dt = D.FetchData(query);
               
                GridView1.DataSource = dt;
                GridView1.DataBind();
            }
            catch (Exception ex)
            {

            }
        }
    }
}