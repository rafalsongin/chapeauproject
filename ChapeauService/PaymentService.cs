using ChapeauDAL;
using ChapeauModel;

namespace ChapeauService
{
    public class PaymentService
    {
        private PaymentDao paymentDb;

        public PaymentService()
        {
            paymentDb = new PaymentDao();
        }

        public List<Payment> GetPayments()
        {
            List<Payment> payments = paymentDb.GetAllPayments();

            return payments;
        }
    }
}