using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TicketSelling.Common;
using TicketSelling.DAO;
using TicketSelling.DAO.Entity;

namespace TicketSelling.UI.Configuration
{
    public partial class FrmTicketSell : UserControl
    {
        public FrmTicketSell()
        {
            InitializeComponent();
            BindName();
        }
        private void BindName()
        {
            try
            {
                cboMovieName.DataSource = null;
                ResMovie res = new MovieDao().GetMovieName();
                if (res.MessageEntity.RespMessageType == CommonResponseMessage.ResSuccessType)
                {
                    cboMovieName.SelectedIndexChanged -= new EventHandler(CboMovieName_SelectedIndexChanged);
                    cboMovieName.DataSource = null;
                    cboMovieName.DataSource = res.LstMovie;
                    cboMovieName.DisplayMember = "Name";
                    cboMovieName.ValueMember = "Id";
                    cboMovieName.SelectedIndex = 0;
                    cboMovieName.SelectedIndexChanged += new EventHandler(CboMovieName_SelectedIndexChanged);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void CboDate_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                cboTime.DataSource = null;
                ResMovieST res = new MovieDao().GetMovieTimeByDateForTicket(Convert.ToDateTime(cboDate.Value));
                if (res.LstMovieST.Count > 0)
                {
                    cboTime.DataSource = res.LstMovieST;
                    cboTime.DisplayMember = "Time";
                    cboTime.ValueMember = "Id";
                    cboTime.SelectedIndex = 0;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void CboMovieName_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                cboDate.MinDate = Convert.ToDateTime("1/1/1753");
                cboDate.MaxDate = Convert.ToDateTime("12/31/9998");
                int MovieId = Convert.ToInt32(cboMovieName.SelectedValue);
                ResMovieSD res = new MovieDao().GetMovieDateById(MovieId);
                if (res.LstMovieSD.Count > 0) //if condition use to control error in datetime bcoz LstMovieSD have O index 
                {
                    cboDate.MinDate = res.LstMovieSD[0].StartDate;
                    cboDate.MaxDate = res.LstMovieSD[0].EndDate;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}

       