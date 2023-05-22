using System.Data;
using System.Data.SqlClient;
using ChapeauModel;

namespace ChapeauDAL
{
    public class TableDao : BaseDao
    {
        public List<Table> GetAllTables()
        {
            // sql query
            string query = "SELECT id, status, covers, is_legal_drinking_age FROM [table]";
            SqlParameter[] sqlParameters = new SqlParameter[0];

            return ReadTables(ExecuteSelectQuery(query, sqlParameters));
        }

        private List<Table> ReadTables(DataTable dataTable)
        {
            List<Table> tables = new List<Table>();

            foreach (DataRow datarow in dataTable.Rows)
            {
                Table table = new Table()
                {
                    Id = (int)datarow["id"],
                    Status = (TableStatus)datarow["status"],
                    Capacity = (int)datarow["covers"],
                    IsLegalDrinkingAge = (bool)datarow["is_legal_drinking_age"]
                };

                tables.Add(table);
            }
            return tables;
        }
    }
}