using System;
using PizzaBox.Domain.Models;

namespace PizzaBox.Client
{
    class Program
    {
        static void Main()
        {
            Initiation();
        }

        static void Initiation()
        {
            System.Console.WriteLine("Choose 1 to order from stores near you.");
            System.Console.WriteLine("Choose 2 to proceed to store menu.");

            int startmen_input;
            int.TryParse(Console.ReadLine(), out startmen_input);

            switch(startmen_input)
            {
                case 1:
                Store.StoreSelectMenu();
                // Get StoreId1
                // OrderMenu method that calls CreatePizzaMethod
                // get pizza w/ data?
                // insert pizza info into Order table
                break;

                case 2:
                Store.StoreMenu();
                break;
            }
        }
    }   
}
