namespace ChapeauModel
{
    public enum OrderStatus
    {
        Pending,InPreparation, Prepared, Served // maybe cancelled as well
    }

    public enum TableStatus
    {
        Available, Busy, Reserved
    }

    public enum EmployeeRole
    {
        Waiter, Bartender, Chef, Manager, Undefined
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