using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TicketSelling.Common;

namespace TicketSelling.DAO.Entity
{
    public class User
    {
        public string RowNumber { get; set; }
        public int Id { get; set; }
        public string Name { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string PhoneNumber { get; set; }
        public string Gmail { get; set; }
    }

    public class ResUser
    {
        public MessageEntity MessageEntity { get; set; }
        public List<User> LstUser { get; set; }
    }
}
