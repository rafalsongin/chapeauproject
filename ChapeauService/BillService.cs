using ChapeauDAL;
using ChapeauModel;

namespace ChapeauService
{
    public class BillService
    {
        private BillDao billDb;

        public BillService()
        {
            billDb = new BillDao();
        }

        public List<Bill> GetBills()
        {
            List<Bill> bills = billDb.GetAllBills();

            return bills;
        }
    }
}