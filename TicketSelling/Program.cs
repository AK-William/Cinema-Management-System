using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using TicketSelling.DAO;
using TicketSelling.UI.Configuration;
using TicketSelling.UI.Report;
using System.Configuration;

namespace TicketSelling
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            //DbConnector.ConnectionString = "Data Source=LAPTOP-ENSCQA99;Initial Catalog=TicketSellingSystem;Integrated Security=True";
            DbConnector.ConnectionString = @"Data Source=LAPTOP-ENSCQA99\SQL2014;Initial Catalog=TicketSellingSystem;Persist Security Info=True;User ID=sa;Password=sasa";
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FrmLogin()); 
        }
    }
}
