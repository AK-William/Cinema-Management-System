using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicketSelling.Common
{
   public class MessageEntity
    {
        public string RespCode { get; set; }
        public string RespDesp { get; set; }
        public string RespMessageType { get; set; }

        public string MovieCoverName { get; set; }

        public int MovieId { get; set; }
    }

    public static class SqlDataSet
    {
        public static MessageEntity Check(DataSet ds, int count, bool isNeedToCheck = true)
        {
            if (!isNeedToCheck)
                return new MessageEntity() { RespCode = "000", RespDesp = "Success!", RespMessageType = CommonResponseMessage.ResSuccessType };
            if (ds == null || ds.Tables.Count == 0 || ds.Tables.Count != count)
                return new MessageEntity() { RespCode = "998", RespDesp = "DataTable Count Error or Is Null", RespMessageType = CommonResponseMessage.ResErrorType };
            return new MessageEntity() { RespCode = "000", RespDesp = "Success!", RespMessageType = CommonResponseMessage.ResSuccessType };
        }
    }

    public static class SqlDataTable
    {
        public static MessageEntity Check(DataTable dt, int SavedRow = 0, bool isNoDataError = false)
        {
            if (dt == null || dt.Rows.Count == 0)
                if (isNoDataError)
                    return new MessageEntity() { RespCode = "000", RespDesp = "Success!", RespMessageType = CommonResponseMessage.ResSuccessType };
                else
                    return new MessageEntity() { RespCode = "998", RespDesp = "Row Count Error or Is Null", RespMessageType = CommonResponseMessage.ResErrorType };
            if (SavedRow > 0)
            {
                if (dt.Rows.Count == SavedRow)
                    return new MessageEntity() { RespCode = "000", RespDesp = "Saving Success!", RespMessageType = CommonResponseMessage.ResSuccessType };
            }
            return new MessageEntity() { RespCode = "000", RespDesp = "Success!", RespMessageType = CommonResponseMessage.ResSuccessType };
        }
    }

}
