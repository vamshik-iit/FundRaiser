using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Configuration;
using System.Data.Common;
using System.Data;


namespace FundRaiser
{
    public class DB
    {

        public static System.Data.Common.DbProviderFactory dbFactory;
        public static string connstring = String.Empty;
        public static string providername = String.Empty;
        private DB conn = null;
        string connectionstring = ConfigurationManager.ConnectionStrings["ConnectionString"].ToString();

        SqlConnection con = new SqlConnection("data source=DESKTOP-KHST74Q; Initial Catalog = FundRaiserG; Trusted_Connection = True;");

        SqlDataAdapter da;
        SqlCommand cmd;
        DataSet ds;
        DataTable dt;
        public DB()
        {
            connstring = ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString;
            providername = "System.Data.SqlClient";
            dbFactory = DbProviderFactories.GetFactory(providername);
        }

        public DataTable FetchData(string qry)
        {
            try
            {
                da = new SqlDataAdapter(qry, con);
                ds = new DataSet();
                con.Open();


                da.Fill(ds, "Data");

                con.Close();

                dt = ds.Tables[0];
            }
            catch (Exception ex)
            {

            }

            return dt;
        }

        public Boolean InsertData(string qry)
        {
            try
            {
                cmd = new SqlCommand();
                con.Open();
                cmd.Connection = con;
                cmd.CommandText = qry;
                cmd.ExecuteNonQuery();
                con.Close();
                return true;
            }
            catch (Exception ex)
            {

            }
            return false;
        }


    }
}