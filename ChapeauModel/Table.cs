namespace ChapeauModel
{
    public class Table
    {
        public int Id { get; set; }
        public TableStatus Status { get; set; }
        public int Capacity { get; set; }
        public bool IsLegalDrinkingAge { get; set; }

        public override string ToString()
        {
            return $"";
        }
    }
}