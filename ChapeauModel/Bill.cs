namespace ChapeauModel
{
    public class Bill
    {
        public int Id { get; set; }
        public float TotalCost { get; set; }
        public float SplitAmount { get; set; }
        public float TipAmount { get; set; }

        public override string ToString()
        {
            return $"";
        }
    }
}