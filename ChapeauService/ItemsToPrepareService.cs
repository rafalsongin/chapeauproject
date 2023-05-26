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

        public List<ItemsToPrepare> GetItems()
        {
            List<ItemsToPrepare> items = ItemsToPrepareDb.GetAllItemsToPrepare();

            return items;
        }
    }
}
