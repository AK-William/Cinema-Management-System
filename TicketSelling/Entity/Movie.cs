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
   public class Movie
    {
        public string RowNumber { get; set; }
        public int Id { get; set; }
        public string Name { get; set; }
        public string MovieCover { get; set; }
        public byte[] MovieCoverByte { get; set; }
        public string Casts { get; set; }
        public string Runtime { get; set; }
        public string MovieType { get; set; }
        public string Description { get; set; }
        public string TrailerLink { get; set; }
    }
    public class ResMovie
    {
        public MessageEntity MessageEntity { get; set; }
        public List<Movie> LstMovie { get; set; }

        public List<MovieSummary> lstMovieSummary { get; set; }
    }

    public class MovieSummary
    {
        public string RowNumber { get; set; }
        public string MovieName { get; set; }
        public int TotalAmount { get; set; }

    }
}
