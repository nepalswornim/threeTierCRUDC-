using DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
   public class BLLInvoice
    {
       public DataTable GetMaxInvoice()
       {
           string sql = "select top 1* from tbl_Invoice order by Invoice_No desc";
           return DAO.SelectUser(sql, null);
       }
      
    }
}
