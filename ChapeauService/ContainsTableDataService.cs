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

        public List<ContainsTableData> GetDishes()
        {
            List<ContainsTableData> datas = containsTableDataDao.GetAllData();

            return datas;
        }

        public void UpdateItemStatus(ItemsToPrepare item)
        {
            containsTableDataDao.UpdateItemStatusInDB(item.OrderId,item.MenuItemId,item.Status);
        }
    }
}
