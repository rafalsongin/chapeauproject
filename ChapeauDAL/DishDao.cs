﻿using System.Data;
using System.Data.SqlClient;
using ChapeauModel;

namespace ChapeauDAL
{
    public class DishDao : BaseDao
    {
        public List<Dish> GetAllDishes()
        {
            string query = "SELECT id, menu_item_id FROM [dish]";

            return ReadTables(ExecuteSelectQuery(query));
        }

        private List<Dish> ReadTables(DataTable dataTable)
        {
            List<Dish> dishes = new List<Dish>();

            foreach (DataRow datarow in dataTable.Rows)
            {
                Dish dish = new Dish()
                {
                    Id = (int)datarow["id"],
                    MenuItemId = (int)datarow["menu_item_id"]
                };

                dishes.Add(dish);
            }
            return dishes;
        }
    }
}