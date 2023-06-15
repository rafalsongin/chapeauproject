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

        public List<ItemsToPrepare> GetItemsDishes()
        {
            List<ItemsToPrepare> items = ItemsToPrepareDb.GetAllItemsToPrepare();
            List<ItemsToPrepare> dishes = new List<ItemsToPrepare>() ;

            foreach (ItemsToPrepare item in items)
            {
                if (item.MenuId != 42344)
                {
                    dishes.Add(item);
                }
            }

            return dishes;
        }

        public List<ItemsToPrepare> GetItemsDrinks()
        {
            List<ItemsToPrepare> items = ItemsToPrepareDb.GetAllItemsToPrepare();
            List<ItemsToPrepare> drinks = new List<ItemsToPrepare>();

            foreach (ItemsToPrepare item in items)
            {
                if (item.MenuId == 42344)
                {
                    item.Comments = string.Empty;
                    drinks.Add(item);
                }
            }

            return drinks;
        }
    }
}
