using ChapeauDAL;
using ChapeauModel;

namespace ChapeauService
{
    public class ContainsTableDataService
    {
        private ContainsTableDataDao containsTableDataDao;

        public ContainsTableDataService ()
        {
            containsTableDataDao = new ContainsTableDataDao ();
        }

        public void UpdateItemStatus(Item item)
        {
            containsTableDataDao.UpdateItemStatusInDB(item.OrderId,item.MenuItemId,item.Status);
        }
    }
}
