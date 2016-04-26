using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using DataAccessLayer;
using System.Data;

namespace BusinessLayer
{
   public class BLLProduct
    {
       public int CreateProduct(int categoryid,string productname,decimal unitprice,int quantity ) {
           string sql = "insert into tbl_Product values( @a,@b,@c,@d)";
           SqlParameter[] param = new SqlParameter[] {
           new SqlParameter("@a",categoryid),
           new SqlParameter("@b", productname),
           new SqlParameter("@c", unitprice),
           new SqlParameter("@d",quantity)
           

           };
      int i=   DAO.IDU(sql, param);
      return i; 
       
       }
       public DataTable LoadGV() {
           string sql = "SELECT* from tbl_Product";
           return DAO.SelectUser(sql, null);
       }
      
       
       
    }
}
