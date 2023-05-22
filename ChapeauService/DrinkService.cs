using ChapeauDAL;
using ChapeauModel;

namespace ChapeauService
{
    public class DrinkService
    {
        private DrinkDao drinkDb;

        public DrinkService()
        {
            drinkDb = new DrinkDao();
        }

        public List<Drink> GetDrinks()
        {
            List<Drink> drinks = drinkDb.GetAllDrinks();

            return drinks;
        }
    }
}