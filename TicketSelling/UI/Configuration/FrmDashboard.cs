using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using TicketSelling.Common;
using TicketSelling.DAO;
using TicketSelling.DAO.Entity;

namespace TicketSelling.UI.Configuration
{
    public partial class FrmDashboard : UserControl
    {
        public FrmDashboard()
        {
            InitializeComponent();
            dgvMovieDB.AutoGenerateColumns = false;
        }

       
    }
}
