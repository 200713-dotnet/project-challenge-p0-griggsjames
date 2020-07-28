
using System;

namespace PizzaBox.Domain.Models
{
    public class Store
    {
        public void StoreSelectMenu()
        {
            System.Console.WriteLine("Choose the store you would like to place an order at");
            System.Console.WriteLine("");
            System.Console.WriteLine("Enter 1 to order at 1234 john st");
            System.Console.WriteLine("Enter 2 to order at 1234 jane st");

            int StoreSelectInp;
            int.TryParse(Console.ReadLine(), out StoreSelectInp);
            int UserId;
            int StoreId;

            switch(StoreSelectInp)
            {
                case 1:
                Console.WriteLine("");
                Console.WriteLine("Please put in your User ID#:");
                int.TryParse(Console.ReadLine(), out UserId);
                StoreId = 1234;
    
                break;

                case 2:
                Console.WriteLine("");
                Console.WriteLine("Please put in your User ID#:");
                int.TryParse(Console.ReadLine(), out UserId);
                StoreId  = 2345;

                break;
            }
        }
    }
}