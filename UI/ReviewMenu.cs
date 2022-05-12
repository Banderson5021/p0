namespace UI;

public class ReviewMenu : IMenu
{
    private readonly IBL _bl;
    public ReviewMenu(IBL bl)
    {
        _bl = bl;
    }
    public void Display() {}

    public string UserChoice()
    {
        throw new NotImplementedException();
    }
}