using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicketSelling.DAO
{
    public class DbConnector
    {
        public static string ConnectionString = "";

        private static SqlConnection con = null;

        SqlConnection cn;
        public DbConnector(string cs)
        {
            cn = new SqlConnection(cs);
        }

        public static SqlConnection Connect()
        {
            //CONNECTION_STRING = System.Configuration.ConfigurationSettings.AppSettings["HRMaster.Properties.Settings.HRConnectionString"].ToString();

            try
            {
                if (con != null)
                {
                    con.Close();
                    con = null;
                }
                if (con == null)
                    con = new SqlConnection(ConnectionString);
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
                return con;
            }

            catch (Exception ex)
            {
                //MessageBox.Show(ex.Message);
            }
            return null;
        }

        //public static void Close()
        //{
        //    con = null;
        //}

        //public bool IsConnection
        //{
        //    get
        //    {
        //        if (cn.State == System.Data.ConnectionState.Closed)
        //            cn.Open();
        //        return true;
        //    }
        //}

    }
}
