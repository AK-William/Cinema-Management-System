using TicketSelling.DAO;
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
using TicketSelling.DAO.Entity;

namespace TicketSelling.DAO.Entity
{
    public class MovieST
    {
        public string RowNumber { get; set; }
        public int Id { get; set; }
        public int SeatId { get; set; }
        public int MovieId { get; set; }
        public string Name { get; set; }
        public DateTime Date { get; set; }
        public string Time { get; set; }

    }
    public class ResMovieST
    {
        public MessageEntity MessageEntity { get; set; }
        public List<MovieST> LstMovieST { get; set; }

    }
}
