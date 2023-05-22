using System.Data;
using System.Data.SqlClient;
using ChapeauModel;

namespace ChapeauDAL
{
    public class PaymentDao : BaseDao
    {
        public List<Drink> GetAllPayments()
        {
            // sql query
            string query = "SELECT id, payment_method, table_id, bill_id FROM [payment]";
            SqlParameter[] sqlParameters = new SqlParameter[0];

            return ReadTables(ExecuteSelectQuery(query, sqlParameters));
        }

        private List<Payment> ReadTables(DataTable dataTable)
        {
            List<Payment> payments = new List<Payment>();

            foreach (DataRow datarow in dataTable.Rows)
            {
                Payment payment = new Payment()
                {
                    Id = (int)datarow["id"],
                    Method = (PaymentMethod)datarow["payment_method"],
                    TableId = (int)datarow["table_id"],
                    BillId = (int)datarow["bill_id"]
                };

                payments.Add(payment);
            }
            return payments;
        }
    }
}