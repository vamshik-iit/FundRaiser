using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace FundRaiser
{
    public partial class _Default : Page
    {
        public List<DataClass> DataClass1 = new List<DataClass>();
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                DB db = new DB();


                string getdataquery = "select * from FundPosts join Users on FundPosts.PostedBy=Users.UserID where IsActive = 1";
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
            catch (Exception ex)
            {

            }
        }
    }
}