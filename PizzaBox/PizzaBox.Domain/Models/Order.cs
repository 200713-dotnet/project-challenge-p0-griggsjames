using System;
using System.Collections.Generic;

namespace PizzaBox.Domain.Models
{
     public class Order
     {
        public static OrderMenu()
        {
           Console.WriteLine("Welcome to the order menu!");
           Console.WriteLine("");
           Console.WriteLine("Please make a selection from the following menu:");
           Console.WriteLine("Enter 1 to Add a pizza");
           Console.WriteLine("Enter 2 to remove a pizza");
           Console.WriteLine("Enter 3 to see your order");
           Console.WriteLine("Enter 4 to view order total");
           Console.WriteLine("Enter 5 to complete order");

            int OrderMenuInp;
            int.TryParse(Console.ReadLine(), out OrderMenuInp);

            var exit = true;

            do
            {
                 switch(OrderMenuInp)
                  {
                  case 1:
                  Console.WriteLine("Enter 1 for a cheese pizza");
                  Console.WriteLine("Enter 2 for a pepporoni pizza");
                  Console.WriteLine("Enter 3 for a hawaiin pizza");

                  int PizzaMenuInp;
                  int.TryParse(Console.ReadLine(), out PizzaMenuInp);

                  switch(PizzaMenuInp)
                  {
                     case 1:
                     //use method in pizza to add a cheese pizza to order?
                     break;

                     case 2:
                     //pepperoni insert into order table method 
                     break

                     case 3:
                     // etc ^^
                     break;
                  }

                  
                  break;

                  case 2:
                  // call RemovePizza method from Pizza
                  break;

                  case 3:
                  // call ViewOrderTot method from Pizza
                  break;

                  case 4:
                  // call ViewOrder method from Pizza
                  break;

                  case 5:
                  exit = false;
                  break;
                  }
            } while (true);

           


        public void ViewOrder()
        {
           //acquire pizzaID data from order table w/ condition of userId
           //print to console
        };

        public void ViewOrderTot()
        {
           //acquire sum of table data for prices of complete order
           //print to console
        };

     }
 }