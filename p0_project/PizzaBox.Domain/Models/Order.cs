using System;
using System.Collections.Generic;
using PizzaBox.Domain.Models;
using System.Text;

namespace PizzaBox.Domain.Models
{
    public class Order
    {   
        public List<Pizza> Pizzas { get; set;}
        public Store store {get;set;}
        public double Price {get;set;}
        public Size Size {get;set;}
        //public Size SizeName {get;set;}
        public Crust Crust{get;set;}
        public Crust CrustName {get; set;}
        
        public int OrderId;
        public static int Count;
        static int PizzaCount = 0;

        public Order()
        {
            OrderId = Count;
            Count ++;
        }

        
    
        public void AddPizza(string name, string crust, string size, List<string>  toppings, double price )
        {   
            Pizzas = Pizzas;
            Pizzas.Add(new Pizza(name, size, crust, toppings,price ));
            foreach (var item in toppings) 
                {
                    Console.WriteLine(item);
                }

        }


        public void CreatePizza()
        {
            bool exit = false;
            if (PizzaCount < 50)
            {
                
                do
                {
                    System.Console.WriteLine("Please choose a pizza: ");
                    System.Console.WriteLine("Enter 1 for cheese pizza");
                    System.Console.WriteLine("Enter 2 for pepperoni pizza");
                    System.Console.WriteLine("Enter 3 to see your order");

                    int CreatePizzInp;
                    int.TryParse(System.Console.ReadLine(), out CreatePizzInp);
                    Size s = new Size();
                    Crust c = new Crust();
                    string name = " ";
                    Order O = new Order();
                    double price;
                        

                    switch(CreatePizzInp)
                    {
                        case 1:
                        List<string> ChToppings = new List<string> { ("cheese") };
                        double chprice = 1.00; 
                        s.ChooseSize();
                        c.ChooseCrust();
                        price = (chprice + s.SizePrice + c.CrustPrice);
                        if(price > 250)
                        {
                            Console.WriteLine("Sorry, You have exceeded the Max Price of Pizzas Allowed");
                            break;
                        }
                        name = "cheese_pizza";
                        PizzaCount ++;
                        O.AddPizza(name, c.CrustName , s.SizeName, ChToppings, price);
                        Console.WriteLine("Pizza Added");
                        break;

                        case 2:
                        List<string> PeppToppings = new List<string> { ("pepperoni"), ("cheese")};
                        double peppprice = 2.00;
                        s.ChooseSize();
                        c.ChooseCrust();
                        price = (peppprice + s.SizePrice + c.CrustPrice);
                        if(price > 250)
                        {
                            Console.WriteLine("Sorry, You have exceeded the Max Price of Pizzas Allowed");
                            break;
                        }
                        name = "pepperoni_pizza";
                        PizzaCount ++;
                        O.AddPizza(name, c.CrustName, s.SizeName, PeppToppings, price);
                        Console.WriteLine("Pizza Added");
                        Console.WriteLine(string.Join(", ", (Size)));
                        break;

                        case 3:
                        Console.WriteLine();
                            foreach (Pizza item in O.Pizzas) 
                            {
                            Console.WriteLine(item);
                            }
                        exit = true;
                        
                        break;

                    }
                }
                while (exit != true);
                System.Console.WriteLine("You will now exit the menu");
            }
                    
            else
                {
                System.Console.WriteLine("Sorry, you have exceeded the amount of allowed pizzas.");
                }

        }
    }
}
