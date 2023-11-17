using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.IO;

namespace FundRaiser
{
    public partial class RequestFunds : System.Web.UI.Page
    {
        DB D = new DB();
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                if (!IsPostBack)
                {
                    fundtype.Items.Clear();
                    featured.Items.Clear();
                    UpdateDropdownList();
                }
            }
            catch(Exception ex)
            {

            }
        }



        protected void UpdateDropdownList()
        {
            try
            {
                DataTable tabledata = new DataTable();
                tabledata = D.FetchData("select * from FundTypes");
                fundtype.Items.Insert(0, "---- Select fund type ----");
                for (int i = 0; i < tabledata.Rows.Count; i++)
                {

                    fundtype.Items.Insert(i+1, tabledata.Rows[i]["Type"].ToString());
                }

                featured.Items.Insert(0, "---- Select Is Featured ----");
                featured.Items.Insert(1, "Yes");
                featured.Items.Insert(2, "No");


            }
            catch (Exception ex)
            {

            }
        }

        protected void sendreq_Click(object sender, EventArgs e)
        {
            try
            {
                int maxpostid = 0;

                DataTable tabledata = new DataTable();
                tabledata = D.FetchData("select max(postid) as postid from FundPosts");

                if(tabledata.Rows.Count ==0)
                {
                    maxpostid = 1;
                }
                else
                {
                    try
                    {
                        maxpostid = Int32.Parse(tabledata.Rows[0]["postid"].ToString()) + 1;
                    }
                    catch(Exception ex)
                    {
                        maxpostid = 1;
                    }
                   
                }



                int isfeatured = 0;
                if (featured.SelectedIndex == 0)
                {
                    ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('Please select featured type')", true);
                    return;
                }
                else if(featured.SelectedIndex == 1)
                {
                    isfeatured = 1;
                }
                else
                {
                    isfeatured = 0;
                }

                if(fundtype.SelectedIndex == 0)
                {
                    ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('Please select fund type')", true);
                    return;

                }





                string updatedFileName = "";
                if (uploadimg.HasFile)
                {
                    try
                    {
                        string fileName = Path.GetFileNameWithoutExtension(uploadimg.FileName);
                        string fileExtension = Path.GetExtension(uploadimg.FileName);
                        if (fileExtension != ".jpg" && fileExtension != ".jpeg" && fileExtension != ".png")
                        {
                            ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('Please upload only image')", true);
                            return;
                        }
                        updatedFileName = fileName + "_" + DateTime.Now.Ticks.ToString() + fileExtension;
                        string savePath = Server.MapPath("~/images/") + updatedFileName;
                        uploadimg.SaveAs(savePath);
                    }
                    catch (Exception ex)
                    {
                        ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('re upload image')", true);
                        return;
                    }
                }



                string query = "INSERT INTO FundPosts(PostID,PostedBy,FundType,FundDescription,AmountRequired,PostedOn,IsActive,IsFeatured,EmotionalStory,Imagepath) " +
                    "VALUES(" + maxpostid + "," + Session["UserID"].ToString() + "," + fundtype.SelectedIndex + ", '" + funddesc.Text + "'," + amountrequired.Text + ", getdate(), 1," + isfeatured + ",'" + story.Text + "','" + updatedFileName + "')";


                if (D.InsertData(query))
                {
                    ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('Success !!!!')", true);

                }
                else
                {
                    ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('Please try again')", true);

                }


            }
            catch(Exception ex)
            {

            }
        }
    }
}