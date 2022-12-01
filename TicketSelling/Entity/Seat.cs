using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TicketSelling.Common;

namespace TicketSelling.DAO.Entity
{
    public class Seat
    {
        public string RowNumber { get; set; }
        public int Id { get; set; }
        public int SeatTypeId { get; set; }
        public string Name { get; set; }
        public int Price { get; set; }
        public int NumberOfSeat { get; set; }
        public string SeatTypeName { get; set; }
    }

    public class ResSeat
    {
        public MessageEntity MessageEntity { get; set; }
        public List<Seat> LstSeat { get; set; }
    }
}
