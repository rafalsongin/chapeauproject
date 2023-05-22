using ChapeauDAL;
using ChapeauModel;

namespace ChapeauService
{
    public class DishService
    {
        private DishDao dishDb;

        public DishService()
        {
            dishDb = new DishDao();
        }

        public List<Dish> GetDishes()
        {
            List<Dish> dishes = dishDb.GetAllDishes();

            return dishes;
        }
    }
}