using ChapeauDAL;
using ChapeauModel;

namespace ChapeauService
{
    public class TableService
    {
        private TableDao tableDb;

        public TableService()
        {
            tableDb = new TableDao();
        }

        public List<Table> GetTables()
        {
            List<Table> tables = tableDb.GetAllTables();

            return tables;
        }
    }
}