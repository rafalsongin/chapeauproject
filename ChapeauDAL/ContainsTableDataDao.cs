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
        string statusString;
        OrderStatus status = new OrderStatus();
        public List<ContainsTableData> GetAllData()
        {
            string query = "SELECT order_id, menu_item_id,status FROM [contains]";

            return ReadTables(ExecuteSelectQuery(query));
        }

        private List<ContainsTableData> ReadTables(DataTable dataTable)
        {
            List<ContainsTableData> datas = new List<ContainsTableData>();

            foreach (DataRow datarow in dataTable.Rows)
            {

                statusString = (string)datarow["status"];

                if (statusString == "Pending")
                {
                    status = OrderStatus.Pending;
                }
                else if (statusString == "InPreparation")
                {
                    status = OrderStatus.InPreparation;
                }
                else if (statusString == "Prepared")
                {
                    status = OrderStatus.Prepared;
                }
                else
                {
                    status = OrderStatus.Served;
                }


                ContainsTableData data = new ContainsTableData()
                {
                    OrderId = (int)datarow["order_id"],
                    MenuItemId = (int)datarow["menu_item_id"],
                    Status = status
                };

                datas.Add(data);
            }
            return datas;
        }

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
