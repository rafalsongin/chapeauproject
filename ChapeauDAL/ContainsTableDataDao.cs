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
    public class ContainsTableDataDao : BaseDao
    {
        public List<ContainsTableData> GetAllData()
        {
            // sql query
            string query = "SELECT order_id, menu_item_id FROM [contains]";
            SqlParameter[] sqlParameters = new SqlParameter[0];

            return ReadTables(ExecuteSelectQuery(query, sqlParameters));
        }

        private List<ContainsTableData> ReadTables(DataTable dataTable)
        {
            List<ContainsTableData> datas = new List<ContainsTableData>();

            foreach (DataRow datarow in dataTable.Rows)
            {
                ContainsTableData data = new ContainsTableData()
                {
                    OrderId = (int)datarow["order_id"],
                    MenuItemId = (int)datarow["menu_item_id"]
                };

                datas.Add(data);
            }
            return datas;
        }
    }
}
