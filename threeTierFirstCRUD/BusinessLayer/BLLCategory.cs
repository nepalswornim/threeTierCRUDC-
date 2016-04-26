using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DataAccessLayer;
using System.Data.SqlClient;


namespace BusinessLayer
{
   public class BLLCategory
    {
       public DataTable GetAllCategory() {
           string sql = "select* from tbl_Category";

           return DAO.SelectUser(sql, null);
           
           
       }
    }

}
