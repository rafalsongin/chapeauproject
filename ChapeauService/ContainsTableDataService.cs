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
    }
}
