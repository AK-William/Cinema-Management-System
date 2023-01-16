using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TicketSelling.Common;
using TicketSelling.DAO;
using TicketSelling.DAO.Entity;
using static TicketSelling.DAO.Entity.Role;

namespace TicketSelling.DAO
{

    public class RoleDao
    {
        SqlConnection sqlConnection;
        SqlCommand scom;
        SqlDataAdapter adapter;


        public ResRole GetAllRole()
        {
            sqlConnection = DbConnector.Connect();
            if (sqlConnection == null)
            {
                return null;
            }
            MessageEntity _MessageEntity = null;
            try
            {
                scom = new SqlCommand(ProcedureConstants.GetAllRole, sqlConnection);
                scom.CommandType = CommandType.Text;
                DataSet ds = new DataSet();
                adapter = new SqlDataAdapter(scom);
                adapter.Fill(ds);
                sqlConnection.Close();

                _MessageEntity = SqlDataSet.Check(ds, 1);
                if (_MessageEntity.RespMessageType != CommonResponseMessage.ResSuccessType)
                    return new ResRole() { MessageEntity = _MessageEntity };

                DataTable dt = ds.Tables[0];
                List<Role> lst = new List<Role>();

                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    lst.Add(new Role
                    {
                        Id = Convert.ToInt32(dt.Rows[i]["Id"]),
                        RoleName = dt.Rows[i]["RoleName"].ToString(),
                    });
                }
                return new ResRole()
                {
                    MessageEntity = new MessageEntity()
                    {
                        RespMessageType = CommonResponseMessage.ResSuccessType
                    },
                    LstRole = lst
                };
            }
            catch (Exception ex)
            {
                _MessageEntity.RespCode = CommonResponseMessage.ExceptionErrorCode;
                _MessageEntity.RespDesp = ex.Message;
                _MessageEntity.RespMessageType = CommonResponseMessage.ResErrorType;
                return new ResRole() { MessageEntity = _MessageEntity };
            }
        }


    }
}
