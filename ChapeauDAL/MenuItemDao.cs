using System.Data;
using System.Data.SqlClient;
using ChapeauModel;

namespace ChapeauDAL
{
    public class MenuItemDao : BaseDao
    {
        public List<MenuItem> GetAllMenuItems()
        {
            // sql query
            string query =  "SELECT id, name, price, sub_type, stock_left, menu_id FROM [menu_item]";
            SqlParameter[] sqlParameters = new SqlParameter[0];

            return ReadTables(ExecuteSelectQuery(query, sqlParameters));
        }

        private List<MenuItem> ReadTables(DataTable dataTable)
        {
            List<MenuItem> menuItems = new List<MenuItem>();

            foreach (DataRow datarow in dataTable.Rows)
            {
                MenuItem menuItem = new MenuItem()
                {
                    Id = (int)datarow["id"],
                    Name = (string)datarow["name"],
                    Price = (float)datarow["price"],
                    Category = (MenuCategory)datarow["sub_type"],
                    StockLeft = (int)datarow["stock_left"],
                    MenuId = (int)datarow["menu_id"]
                };

                menuItems.Add(menuItem);
            }
            return menuItems;
        }
    }
}