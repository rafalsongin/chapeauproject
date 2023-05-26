﻿using ChapeauModel;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChapeauDAL
{
    public class ContainsTableDataDao : BaseDao
    {
        string statusString;
        OrderStatus status = new OrderStatus();
        public List<ContainsTableData> GetAllData()
        {
            // sql query
            string query = "SELECT order_id, menu_item_id,status FROM [contains]";
            SqlParameter[] sqlParameters = new SqlParameter[0];

            return ReadTables(ExecuteSelectQuery(query, sqlParameters));
        }

        private List<ContainsTableData> ReadTables(DataTable dataTable)
        {
            List<ContainsTableData> datas = new List<ContainsTableData>();

            foreach (DataRow datarow in dataTable.Rows)
            {

                statusString = (string)datarow["status"];

                if (statusString == "Pending")
                {
                    status = OrderStatus.Pending;
                }
                else if (statusString == "InPreparation")
                {
                    status = OrderStatus.InPreparation;
                }
                else if (statusString == "Prepared")
                {
                    status = OrderStatus.Prepared;
                }
                else
                {
                    status = OrderStatus.Served;
                }


                ContainsTableData data = new ContainsTableData()
                {
                    OrderId = (int)datarow["order_id"],
                    MenuItemId = (int)datarow["menu_item_id"],
                    Status = status
                };

                datas.Add(data);
            }
            return datas;
        }
    }
}
