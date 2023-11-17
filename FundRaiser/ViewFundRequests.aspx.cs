using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
namespace FundRaiser
{
    public partial class ViewFundRequests : System.Web.UI.Page
    {
        public List<DataClass> DataClass1 = new List<DataClass>();
        DB db = new DB();
        string query = "";
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                LoadFundRequestDetails();
                DataTable dt = new DataTable();

                category.Items.Clear();
                category.Items.Insert(0, "--select category--");
                query = "select * from FundTypes";
                dt = db.FetchData(query);
                if(dt.Rows.Count > 0)
                {
                    for(int i=1;i<=dt.Rows.Count;i++)
                    {
                        category.Items.Insert(i, dt.Rows[i-1]["Type"].ToString());
                    }
                }

                Location.Items.Clear();
                Location.Items.Insert(0, "--select location--");
                query = "select distinct Country from Zipcodes";
                dt = db.FetchData(query);
                if (dt.Rows.Count > 0)
                {
                    for (int i = 1; i <= dt.Rows.Count; i++)
                    {
                        Location.Items.Insert(i, dt.Rows[i-1]["Country"].ToString());
                    }
                }



                Featured.Items.Clear();
                Featured.Items.Insert(0, "--select featured--");
                Featured.Items.Insert(1, "Yes");
                Featured.Items.Insert(2, "No");




            }
        }





        protected void LoadFundRequestDetails()
        {
            try
            {
               
                
                    string getdataquery = "select * from FundPosts join Users on FundPosts.PostedBy=Users.UserID where IsActive = 1";
                    DataTable dt = new DataTable();
                    dt = db.FetchData(getdataquery);

                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        DataClass dc = new DataClass();
                        dc.PostID = dt.Rows[i]["PostID"].ToString();

                        dc.PostedBy = dt.Rows[i]["UserName"].ToString();
                      
                        dc.Title = dt.Rows[i]["FundDescription"].ToString();
                        dc.URL= "~/images/" + dt.Rows[i]["ImagePath"].ToString();
                        dc.AmountReq = dt.Rows[i]["AmountRequired"].ToString();
                        dc.PostedOn = dt.Rows[i]["PostedOn"].ToString();
                        DataClass1.Add(dc);
                    }

                
            }
            catch (Exception ex)
            {

            }
        }

        protected void Filter_Click(object sender, EventArgs e)
        {
            try
            {
                string getdataquery = "select * from FundPosts join Users on FundPosts.PostedBy=Users.UserID left join UserAddress ua on ua.UserID=Users.UserID " +
                    " left join Zipcodes z on z.Zipcode=ua.Zipcode " +
                    " where IsActive = 1 ";



                if(FundTitle.Text != "")
                {
                    getdataquery = getdataquery + " and FundDescription like '%" + FundTitle.Text + "%' ";
                }

                if(category.SelectedIndex != 0)
                {
                    getdataquery = getdataquery + " and FundType=" + category.SelectedIndex.ToString() + " ";
                }

                if (Location.SelectedIndex != 0)
                {
                    getdataquery = getdataquery + " and z.Country='" + Location.SelectedValue.ToString() + "' ";
                }

                if (Featured.SelectedIndex != 0)
                {
                    getdataquery = getdataquery + " and IsFeatured=" + Featured.SelectedIndex.ToString() + " ";
                }



                DataTable dt = new DataTable();
                dt = db.FetchData(getdataquery);

                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    DataClass dc = new DataClass();
                    dc.PostID = dt.Rows[i]["PostID"].ToString();

                    dc.PostedBy = dt.Rows[i]["UserName"].ToString();

                    dc.Title = dt.Rows[i]["FundDescription"].ToString();
                    dc.URL = "~/images/" + dt.Rows[i]["ImagePath"].ToString();
                    dc.AmountReq = dt.Rows[i]["AmountRequired"].ToString();
                    dc.PostedOn = dt.Rows[i]["PostedOn"].ToString();
                    DataClass1.Add(dc);
                }
            }
            catch(Exception ex)
            {

            }
        }
    }
}