using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UI
{
    internal class SignUpMenu : IMenu
    {
        public void Display()
        {
            Console.WriteLine("Sign In Menu");
            Console.WriteLine("Please choose from the following options:");
            Console.WriteLine("Press <0> to quit the program.");
            Console.WriteLine("Press <1> to proceed with making an account.");
            UserChoice();
        }

        public string UserChoice()
        {
            string 
        }
    }
}
