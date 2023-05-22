namespace ChapeauModel
{
    public class Bill
    {
        public int Id { get; set; }
        public double TotalCost { get; set; }
        public double SplitAmount { get; set; }
        public double TipAmount { get; set; }

        public override string ToString()
        {
            return $"";
        }
    }
}