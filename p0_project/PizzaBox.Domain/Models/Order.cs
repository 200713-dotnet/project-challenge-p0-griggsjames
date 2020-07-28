using System;
using System.Collections.Generic;
using PizzaBoz.Domain.Models;

namespace PizzaBox.Domain.Models
{
    public class Order
    {   
        private static int Count =0;
        public int OrderId {get;}
        public List<Pizza> Pizzas {get;set;}

        public Order()
        {
            OrderId = Count;
            Count ++;
        }
        
        public void AddPizza(Pizza p)
        {
            Pizzas.Add(p);
        }
        
    
        public void CreatePizza()
        {
            System.Console.WriteLine("Please choose a pizza: ");
            System.Console.WriteLine("Enter 1 for cheese pizza");
            System.Console.WriteLine("Enter 2 for pepperoni pizza");
            System.Console.WriteLine("Enter 3 to see your order");

            int CreatePizzInp;
            int.TryParse(System.Console.ReadLine(), out CreatePizzInp);
            List<string> toppings = new List<string>();
            Size s = new Size();
            Crust c = new Crust();
            string name = " ";


            switch(CreatePizzInp)
            {
                case 1:
                toppings.Add("cheese");
                s.ChooseSize();
                c.ChooseCrust();
                name = "cheese_pizza";
                break;

                case 2:
                toppings.Add("pepperoni");
                s.ChooseSize();
                c.ChooseCrust();
                name = "pepperoni_pizza";
                break;

                case 3:
                foreach(var item in Pizzas)
                {
                    System.Console.WriteLine(item);
                }
                break;
            }

            Pizza NewPizza = new Pizza(name, s.SizeName, c.CrustName, toppings);
            AddPizza(NewPizza);

        }
    }
}