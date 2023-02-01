using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TicketSelling.Common;

namespace TicketSelling.Entity
{
    public class SaleHead
    {
        public string RowNumber { get; set; }
        public int Id { get; set; }
        public int MovieId { get; set; }
        public DateTime MovieDate { get; set; }
        public string MovieTime { get; set; }
        public string CustomerName { get; set; }
        public string Phone { get; set; }
        public int TotalPrice { get; set; }

        public List<SaleDetail> lstSaleDetail { get; set; }

    }

    public class SaleDetail
    {
        public int Id { get; set; }
        public int HeadId { get; set; }
        public int SeatTypeId { get; set; }
        public int SeatId { get; set; }
        public int Price { get; set; }

    }

    public class SaleReport
    {
        public string RowNumber { get; set; }
        public string MovieName { get; set; }
        public DateTime MovieDate { get; set; }
        public string MovieTime { get; set; }
        public string SeatName { get; set; }
        public int Price { get; set; }
    }

    public class ResSale
    {
        public MessageEntity MessageEntity { get; set; }
        public List<SaleHead> lstSale { get; set; }
        public List<SaleDetail> lstSaleDetail { get; set; }
        public List<SaleReport> lstSaleReport { get; set; }
    }
}
