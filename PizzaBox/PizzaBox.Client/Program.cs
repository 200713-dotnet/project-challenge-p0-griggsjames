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
            System.Console.WriteLine("Choose 1 to order a pizza");
            System.Console.WriteLine("Choose 2 to proceed to store login.");

            int startmen_input;
            int.TryParse(Console.ReadLine(), out startmen_input);

            switch(startmen_input)
            {
                case 1:
                // user order pizza here
                break;

                case 2:
                Store.StoreMenu();
                break;
            }
        }
    }   
}
