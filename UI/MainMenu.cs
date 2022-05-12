namespace UI;
public class MainMenu : IMenu 
{
    private IBL _bl;

    public MainMenu(IBL bl)
    {
        _bl = bl;
    }

    public void Display()
    {
        Console.WriteLine("Welcome to Restaurant Reviews!\nWhat would you like to do?");
        Console.WriteLine("Press <0> to quit the program.");
        Console.WriteLine("Press <1> to Sign in");
        Console.WriteLine("Press <2> to Sign up if you don't have an account");
        UserChoice();
    }
    public string UserChoice()
    {
        string userInput = Console.ReadLine();

        switch (userInput)
        {
            case "0":
                return "Quit";
            case "1":
                return "SignIn";
            case "2":
                return "SignUp";
            default:
                Console.WriteLine("Invalid Input...try again");
                return null;

                

        }
    }
}
