using System.Data;
using System.Data.SqlClient;
using ChapeauModel;

namespace ChapeauDAL
{
    public class MenuDao : BaseDao
    {
        public List<Menu> GetAllMenus()
        {
            // sql query
            string query =  "SELECT id, type FROM [menu]";
            SqlParameter[] sqlParameters = new SqlParameter[0];

            return ReadTables(ExecuteSelectQuery(query, sqlParameters));
        }

        private List<Menu> ReadTables(DataTable dataTable)
        {
            List<Menu> menus = new List<Menu>();

            foreach (DataRow datarow in dataTable.Rows)
            {
                Menu menu = new Menu()
                {
                    Id = (int)datarow["id"],
                    Type = (MenuType)datarow["type"],
                };

                menus.Add(menu);
            }
            return menus;
        }
    }
}