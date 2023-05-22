namespace ChapeauModel
{
    public enum OrderStatus
    {
        Pending, Preparing, Ready // maybe cancelled as well
    }

    public enum TableStatus
    {
        Available, Busy, Reserved
    }

    public enum EmployeeRole
    {
        Waiter, Bartender, Chef, Manager
    }

    // is needed?
    public enum DrinkServingType 
    {
        Glass, Bottle
    }

    public enum MenuCategory 
    {
        Starters, Entremets, MainDishes, Desserts, SoftDrinks, Wines, BeersOnTap, SpiritDrinks, CoffeTea 
    }

    public enum MenuType
    {
        Lunch, Dinner, Drinks
    }

    public enum PaymentMethod
    {
        DebitCard, CreditCard, Cash
    }
}