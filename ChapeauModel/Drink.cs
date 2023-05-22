namespace ChapeauModel
{
    public class Drink
    {
        public int Id { get; set; }
        public bool isAlcoholic { get; set; }
        //DrinkServingType ServingType { get; set; } (do we need this one?)
        public int MenuItemId { get; set; }

        public override string ToString()
        {
            return $"";
        }
    }
}