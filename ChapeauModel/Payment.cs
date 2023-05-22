namespace ChapeauModel
{
    public class Payment
    {
        public int Id { get; set; }
        public PaymentMethod Method { get; set; }
        public int TableId { get; set; }
        public int BillId { get; set; }

        public override string ToString()
        {
            return $"";
        }
    }
}