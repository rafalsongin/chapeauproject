using System.Data;
using System.Data.SqlClient;
using ChapeauModel;

namespace ChapeauDAL
{
    public class BillDao : BaseDao
    {
        public List<Bill> GetAllBills()
        {
            // sql query
            string query = "SELECT id, total_cost, split_amount, tip_amount FROM [bill]";
            SqlParameter[] sqlParameters = new SqlParameter[0];

            return ReadTables(ExecuteSelectQuery(query, sqlParameters));
        }

        private List<Bill> ReadTables(DataTable dataTable)
        {
            List<Bill> bills = new List<Bill>();

            foreach (DataRow datarow in dataTable.Rows)
            {
                Bill bill = new Bill()
                {
                    Id = (int)datarow["id"],
                    TotalCost = (float)datarow["total_cost"],
                    SplitAmount = (float)datarow["split_amount"],
                    TipAmount = (float)datarow["tip_amount"]
                };

                bills.Add(bill);
            }
            return bills;
        }
    }
}