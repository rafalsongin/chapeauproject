namespace ChapeauModel
{
    public class Order
    {
        public int Id { get; set; }
        public int Host { get; set; }
        public OrderStatus Status { get; set; }
        public DateTime OrderTakenTime { get; set; }
        public string Comments { get; set; }
        public int TableId { get; set; }
        public int BillId { get; set; }

        public override string ToString()
        {
            return $"";
        }
    }
}