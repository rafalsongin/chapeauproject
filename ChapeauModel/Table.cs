using System.Data;

namespace ChapeauModel
{
    public class Table
    {
        public string status = "";

        public int Id { get; set; }
        public TableStatus Status
        {
            get
            {
                if (status == "Available")
                {
                    return TableStatus.Available;
                }
                else if (status == "Occupied")
                {
                    return TableStatus.Occupied;
                }
                else if (status == "Reserved")
                {
                    return TableStatus.Reserved;
                }
                else if (status == "Ordered")
                {
                    return TableStatus.Ordered;
                }
                else
                {
                    return TableStatus.Undefined;
                }
            }
        }
        public int Capacity { get; set; }
        public bool IsLegalDrinkingAge { get; set; }

        public override string ToString()
        {
            return $"";
        }
    }
}