using ChapeauDAL;
using ChapeauModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChapeauService
{
    public class ItemsPreparedService
    {
        private ItemsPreparedDao ItemsToPrepareDb;

        public ItemsPreparedService()
        {
            ItemsToPrepareDb = new ItemsPreparedDao();
        }

        public List<ItemsPrepared> GetItemsDishes()
        {
            List<ItemsPrepared> items = ItemsToPrepareDb.GetAllItemsPrepared();
            List<ItemsPrepared> dishes = new List<ItemsPrepared>();

            foreach (ItemsPrepared item in items)
            {
                if (item.MenuId != 42344)
                {
                    dishes.Add(item);
                }
            }

            return dishes;
        }

        public List<ItemsPrepared> GetItemsDrinks()
        {
            List<ItemsPrepared> items = ItemsToPrepareDb.GetAllItemsPrepared();
            List<ItemsPrepared> drinks = new List<ItemsPrepared>();

            foreach (ItemsPrepared item in items)
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
