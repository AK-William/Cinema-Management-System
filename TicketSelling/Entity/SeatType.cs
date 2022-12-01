using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TicketSelling.Common;

namespace TicketSelling.DAO.Entity
{
    public class SeatType
    {
        public string RowNumber { get; set; }
        public int Id { get; set; }
        public string Name { get; set; }
        public string Note { get; set; }
    }

    public class ResSeatType
    {
        public MessageEntity MessageEntity { get; set; }
        public List<SeatType> LstSeatType { get; set; }
    }
}
