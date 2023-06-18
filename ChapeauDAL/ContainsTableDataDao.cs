using ChapeauModel;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace ChapeauDAL
{
    public class ContainsTableDataDao : BaseDao
    {
        public void UpdateItemStatusInDB(int orderId,int menuItemId,OrderStatus orderStatus)
        {
            string querry = "Update [contains] SET [status] = @Status WHERE order_id = @OrderID AND menu_item_id = @menu_item_id;";
            SqlParameter[] sqlParameters = new SqlParameter[3];
            sqlParameters[0] = new SqlParameter("@Status", SqlDbType.VarChar) { Value = orderStatus.ToString() };
            sqlParameters[1] = new SqlParameter("@OrderID", SqlDbType.Int) { Value = orderId };
            sqlParameters[2] = new SqlParameter("@menu_item_id", SqlDbType.VarChar) { Value = menuItemId };
            ExecuteEditQuery(querry, sqlParameters);
        }


    }
}
