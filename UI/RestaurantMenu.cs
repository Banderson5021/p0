namespace UI;

public class RestaurantMenu : IMenu
{
    private IBL _bl;

    public RestaurantMenu(IBL bl) 
    {
        _bl = bl;
    }

    public void Display()
    {
        throw new NotImplementedException();
    }

    public string UserChoice()
    {
        throw new NotImplementedException();
    }
}