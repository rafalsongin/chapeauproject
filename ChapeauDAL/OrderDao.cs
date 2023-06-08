using System.Data;
using System.Data.SqlClient;
using ChapeauModel;

namespace ChapeauDAL
{
    public class OrderDao : BaseDao
    {
        public List<Order> GetAllOrders()
        {
            string query = "SELECT id, host, order_taken_time, comments, table_id, bill_id FROM [order]";

            return ReadTables(ExecuteSelectQuery(query));
        }
       
        private List<Order> ReadTables(DataTable dataTable)
        {
            List<Order> orders = new List<Order>();

            foreach (DataRow datarow in dataTable.Rows)
            {
                Order order = new Order()
                {
                    Id = (int)datarow["id"],
                    Host = (int)datarow["host"],
                    OrderTakenTime = (DateTime)datarow["order_taken_time"],
                    Comments = datarow["comments"] == DBNull.Value ? string.Empty : (string)datarow["comments"],
                    TableId = (int)datarow["table_id"],
                    BillId = (int)datarow["bill_id"]
                };

                orders.Add(order);
            }
            return orders;
        }
    }
}