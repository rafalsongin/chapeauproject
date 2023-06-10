using ChapeauModel;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChapeauDAL
{
    public class ItemsToPrepareDao : BaseDao
    {
        string statusString;
        OrderStatus status = new OrderStatus();
        public List<ItemsToPrepare> GetAllItemsToPrepare() // int menuid maybe pass the id number here to filter, for the having, like having menuid = @this menu id
        {
            // sql query
            string query = "SELECT [order_id],COUNT(ORDER_ID) AS [COUNT],menu_item.[name],table_id,[contains].[status],[contains].menu_item_id,covers,menu_item.[menu_id]\r\n\tFROM [contains]\r\n\tjoin [menu_item] on menu_item.id = [contains].menu_item_id\r\n\tjoin [order] on [contains].order_id = [order].id\r\n\tjoin [table] on [table].id = [order].table_id\r\n\tGROUP BY [order_id],menu_item.[name],table_id,[contains].[status],[contains].menu_item_id,covers,menu_item.[menu_id]\r\n\tHAVING [contains].[status] <> 'Served';";

            return ReadTables(ExecuteSelectQuery(query));
        }

        private List<ItemsToPrepare> ReadTables(DataTable dataTable)
        {
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

                ItemsToPrepare item = new ItemsToPrepare()
                {
                    OrderId = (int)datarow["order_id"],
                    Count = (int)datarow["COUNT"],
                    Name = (string)datarow["name"],
                    TableId = (int)datarow["table_id"],
                    Status = status,
                    MenuItemId = (int)datarow["menu_item_id"],
                    Covers = (int)datarow["covers"],
                    MenuId = (int)datarow["menu_id"]                   
                };

                itemsToPrepare.Add(item);
            }
            return itemsToPrepare;
        }
    }
}
