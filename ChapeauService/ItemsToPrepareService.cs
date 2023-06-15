using ChapeauDAL;
using ChapeauModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChapeauService
{
    public class ItemsToPrepareService
    {
        private ItemsToPrepareDao ItemsToPrepareDb;

        public ItemsToPrepareService()
        {
            ItemsToPrepareDb = new ItemsToPrepareDao();
        }

        public List<Item> GetItemsDishes()
        {
            List<Item> items = ItemsToPrepareDb.GetAllItemsToPrepare();
            List<Item> dishes = new List<Item>() ;

            foreach (Item item in items)
            {
                if (item.MenuType != MenuType.Drinks)             // this number represents the id of the DRINKS CATEGORY in the database
                {                                     // it is used to FILTER drinks from food
                    dishes.Add(item);
                }
            }

            return dishes;
        }

        public List<Item> GetItemsDrinks()
        {
            List<Item> items = ItemsToPrepareDb.GetAllItemsToPrepare();
            List<Item> drinks = new List<Item>();

            foreach (Item item in items)
            {
                if (item.MenuType == MenuType.Drinks)
                {
                    item.Comments = string.Empty;
                    drinks.Add(item);
                }
            }

            return drinks;
        }
    }
}
