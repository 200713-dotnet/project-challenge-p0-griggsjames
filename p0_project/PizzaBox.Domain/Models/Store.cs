
using System;
using System.Collections.Generic;

namespace PizzaBox.Domain.Models
{
    public class Store
    {
        public string UserId {get;set;}
        public List<Order> Orders { get; set; }

        public int StoreId {get;set;}
        public void StoreSelectMenu()
        {
            System.Console.WriteLine("Choose the store you would like to place an order at");
            System.Console.WriteLine("");
            System.Console.WriteLine("Enter 1 to order at 1234 john st");
            System.Console.WriteLine("Enter 2 to order at 1234 jane st");

            int StoreSelectInp;
            int.TryParse(Console.ReadLine(), out StoreSelectInp);

            switch(StoreSelectInp)
            {
                case 1:
                Console.WriteLine("");
                Console.WriteLine("Please put in your User ID#:");
                UserId = Console.ReadLine();
                StoreId = 1212;

                break;

                case 2:
                Console.WriteLine("");
                Console.WriteLine("Please put in your User ID#:");
                UserId = Console.ReadLine();
                StoreId = 2323;
                break;
            }
        }

        public void StoreMenu()
        {
            System.Console.WriteLine("Welcome to your store menu!");
            System.Console.WriteLine();
            System.Console.WriteLine("Please enter your store ID#:");
            
            int StoreId;
            int.TryParse(System.Console.ReadLine(), out StoreId);


            System.Console.WriteLine("Please select an option from the following menu:");
            System.Console.WriteLine("Press 1 in order to see store orders");
            System.Console.WriteLine("Press 2 in order to see total revenue for the week");

            int StoreInp;
            int.TryParse(System.Console.ReadLine(), out StoreInp);

            switch(StoreInp)
            {
                case 1:  
                //see store orders
     
                break;

                case 2: 
                //see total revenue for the week
                        
                break;
            }

        }
    }
}