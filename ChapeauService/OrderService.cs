using ChapeauDAL;
using ChapeauModel;

namespace ChapeauService
{
    public class OrderService
    {
        private OrderDao orderDb;

        public OrderService()
        {
            orderDb = new OrderDao();
        }

        public List<Order> GetOrders()
        {
            List<Order> orders = orderDb.GetAllOrders();

            return orders;
        }
    }
}