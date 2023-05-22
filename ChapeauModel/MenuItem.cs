namespace ChapeauModel
{
    public class MenuItem
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public float Price { get; set; }
        public MenuCategory Category { get; set; }
        public int StockLeft { get; set; }
        public int MenuId { get; set; }

        public override string ToString()
        {
            return $"";
        }
    }
}