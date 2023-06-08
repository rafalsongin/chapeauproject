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

        public Table GetTableById(int id)
        {
            Table table = tableDb.GetTableById(id);

            return table;
        }

        public List<Table> GetAllTables()
        {
            List<Table> tables = tableDb.GetAllTables();

            return tables;
        }
        
        public void ChangeTableStatus(Table table)
        {
            tableDb.ChangeTableStatus(table);
        }
    }
}