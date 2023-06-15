using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChapeauModel
{
    public class Item
    {
        public int OrderId { get; set; }
        public int Count { get; set; }
        public string Name { get; set; }
        public int TableId { get; set; }
        public OrderStatus Status { get; set; }
        public int MenuItemId { get; set; }
        public int Covers { get; set; }
        public MenuType MenuType { get; set; }
        public TimeOnly OrderTime { get; set; }
        public string Comments { get; set; }
        public TimeSpan PreparationTimer { get; set; }
    }
}
