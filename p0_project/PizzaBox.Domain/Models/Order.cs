using System;
using System.Collections.Generic;
using PizzaBox.Domain.Models;

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

        Pizza pizza = new Pizza();
        public void AddPizza(Pizza pizza)
        {
            Pizzas.Add(pizza);
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
            int PizzaCount=0;

            if (PizzaCount < 250)
            {
                do
                {

                    switch(CreatePizzInp)
                    {
                        case 1:
                        
                        toppings.Add("cheese");
                        s.ChooseSize();
                        c.ChooseCrust();
                        name = "cheese_pizza";
                        PizzaCount ++;
                        break;

                        case 2:
                        toppings.Add("pepperoni");
                        s.ChooseSize();
                        c.ChooseCrust();
                        name = "pepperoni_pizza";
                        PizzaCount ++;
                        break;

                        case 3:
                        foreach(var item in Pizzas)
                        {
                            System.Console.WriteLine(item);
                        }
                        break;
                        }
                    

                    Pizza NewPizza = new Pizza(name, s.SizeName, c.CrustName, toppings);
                    Order O = new Order();
                    O.AddPizza(NewPizza);

                }
                while (CreatePizzInp <= 3);
                
                
            }
            else
            {
                System.Console.WriteLine("You will now exit the menu");
            }

        }
    }
}