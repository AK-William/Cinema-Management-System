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
    public class Role
    {

        public int Id { get; set; }
        public string RoleName { get; set; }

        public class ResRole
        {
            public MessageEntity MessageEntity { get; set; }
            public List<Role> LstRole { get; set; }
        }
    }
}