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
    public class Admin
    {
        public string RowNumber { get; set; }
        public int Id { get; set; }
        public string Name { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string Photo { get; set; }
        public byte[] PhotoByte { get; set; }
        public string Gmail { get; set; }
        public string PhoneNumber { get; set; }
        public string NRC { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string Postcode { get; set; }
    }
    public class ResAdmin
    {
        public MessageEntity MessageEntity { get; set; }
        public List<Admin> LstAdmin { get; set; }
    }
}
