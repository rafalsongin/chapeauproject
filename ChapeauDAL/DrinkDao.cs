using System.Data;
using System.Data.SqlClient;
using ChapeauModel;

namespace ChapeauDAL
{
    public class DrinkDao : BaseDao
    {
        public List<Drink> GetAllDrinks()
        {
            // sql query
            string query =  "SELECT id, is_alcoholic, menu_item_id FROM [drink]";
            SqlParameter[] sqlParameters = new SqlParameter[0];

            return ReadTables(ExecuteSelectQuery(query, sqlParameters));
        }

        private List<Drink> ReadTables(DataTable dataTable)
        {
            List<Drink> drinks = new List<Drink>();

            foreach (DataRow datarow in dataTable.Rows)
            {
                Drink drink = new Drink()
                {
                    Id = (int)datarow["id"],
                    isAlcoholic = (bool)datarow["is_alcoholic"],
                    MenuItemId = (int)datarow["menu_item_id"],
                };

                drinks.Add(drink);
            }
            return drinks;
        }
    }
}