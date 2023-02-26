using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TicketSelling.Common;

namespace TicketSelling.Entity
{
    public class TicketData
    {
        public string MovieName { get; set; }
        public DateTime MovieDate { get; set; }
        public string MovieTime { get; set; }
        public string CustomerName { get; set; }
        public string Phone { get; set; }
        public string SeatName { get; set; }
        public int TotalPrice { get; set; }
        public string StrMovieDate { get { return MovieDate.ToString("dd/MM/yyyy"); } }


    }

    public class ResTicketData
    {
        public MessageEntity MessageEntity { get; set; }

        public List<TicketData> lstTicketData { get; set; }
    }
}
