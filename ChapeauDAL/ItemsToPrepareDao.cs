using ChapeauModel;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;


namespace ChapeauDAL
{
    public class ItemsToPrepareDao : BaseDao
    {
        public List<ItemsToPrepare> GetAllItemsToPrepare() // int menuid maybe pass the id number here to filter, for the having, like having menuid = @this menu id
        {
            // sql query
            string query = "SELECT [order_id],COUNT(ORDER_ID) AS [COUNT],menu_items.[name],table_id,[contains].[status],[contains].menu_item_id,covers,menu_items.[menu_id], [order].[order_taken_time],[order].comments,menu_items.time_to_prepare\r\n\t" +
                "FROM [contains]\r\n\t" +
                "JOIN [menu_items] on menu_items.id = [contains].menu_item_id\r\n\t" +
                "JOIN [order] on [contains].order_id = [order].id\r\n\t" +
                "JOIN [table] on [table].id = [order].table_id\r\n\t" +
                "GROUP BY [order].[order_taken_time], [order_id],menu_items.[name],table_id,[contains].[status],[contains].menu_item_id,covers,menu_items.[menu_id],[order].comments,menu_items.time_to_prepare\r\n\t" +
                "HAVING [contains].[status] <> 'Served';";

            return ReadTables(ExecuteSelectQuery(query));
        }

        private List<ItemsToPrepare> ReadTables(DataTable dataTable)
        {
            string statusString;
            DateTime dateTime = new DateTime();
            OrderStatus status = new OrderStatus();

            List<ItemsToPrepare> itemsToPrepare = new List<ItemsToPrepare>();

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

                dateTime = (DateTime)datarow["order_taken_time"];

                ItemsToPrepare item = new ItemsToPrepare()
                {
                    OrderId = (int)datarow["order_id"],
                    Count = (int)datarow["COUNT"],
                    Name = (string)datarow["name"],
                    TableId = (int)datarow["table_id"],
                    Status = status,
                    MenuItemId = (int)datarow["menu_item_id"],
                    Covers = (int)datarow["covers"],
                    MenuId = (int)datarow["menu_id"],
                    OrderTime = TimeOnly.FromDateTime(dateTime),
                    PreparationTimer = TimeSpan.FromMinutes((int)datarow["time_to_prepare"]),
                    Comments = datarow["comments"] as string ?? string.Empty
                };

                itemsToPrepare.Add(item);
            }
            return itemsToPrepare;
        }
    }
}
