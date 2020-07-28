using System;
using PizzaBox.Client;
using PizzaBox.Domain.Models;


namespace PizzaBox.Client
{
    public class Startup
    {
       public void Initiation()
        {
            System.Console.WriteLine("Choose 1 to order from stores near you.");
            System.Console.WriteLine("Choose 2 to proceed to store menu.");

            int startmen_input;
            int.TryParse(Console.ReadLine(), out startmen_input);
            Store s = new Store();
            Order o = new Order();

            switch(startmen_input)
            {
                case 1:
                s.StoreSelectMenu();
                o.CreatePizza();
                break;

                case 2:
                //s.StoreMenu();
                break;
            }
        }
        
    }
}