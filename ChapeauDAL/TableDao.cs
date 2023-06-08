using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using ChapeauModel;

namespace ChapeauDAL
{
    public class TableDao : BaseDao
    {
        public List<Table> GetAllTables()
        {
            // sql query
            string query = "SELECT id, status, covers, is_legal_drinking_age FROM [table]";

            return ReadTables(ExecuteSelectQuery(query));
        }

        private List<Table> ReadTables(DataTable dataTable)
        {
            List<Table> tables = new List<Table>();

            foreach (DataRow datarow in dataTable.Rows)
            {
                Table table = new Table()
                {
                    Id = (int)datarow["id"],
                    status = (string)datarow["status"],
                    Capacity = (int)datarow["covers"],
                    IsLegalDrinkingAge = (bool)datarow["is_legal_drinking_age"]
                };

                tables.Add(table);
            }
            return tables;
        }

        public Table GetTableById(int id)
        {
            string query = @"SELECT id, status, covers, is_legal_drinking_age 
                            FROM [table] 
                            WHERE id = @Id";

            // prevents from SQL injection
            SqlParameter[] sqlParameters = new SqlParameter[1]
            {
                new SqlParameter("@Id", id),
            };

            return ReadTable(ExecuteSelectQueryWithParameters(query, sqlParameters));
        }

        private Table ReadTable(DataTable dataTable)
        {
            DataRow datarow = dataTable.Rows[0];
            Table table = new Table()
            {
                Id = (int)datarow["id"],
                status = (string)datarow["status"],
                Capacity = (int)datarow["covers"],
                IsLegalDrinkingAge = (bool)datarow["is_legal_drinking_age"]
            };

            return table;
        }

        public void ChangeTableStatus(Table table)
        {
            string query = @"UPDATE [table] 
                            SET status = @TableStatus 
                            WHERE Id = @Id";

            SqlParameter[] sqlParameters = new SqlParameter[2]
            {
                new SqlParameter("@Id", table.Id),
                new SqlParameter("@TableStatus", table.Status.ToString())
            };

            ExecuteEditQuery(query, sqlParameters);
        }
    }
}