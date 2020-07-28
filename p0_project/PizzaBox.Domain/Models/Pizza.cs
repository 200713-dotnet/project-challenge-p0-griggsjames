using System.Collections.Generic;
using PizzaBox.Domain.Models;

namespace PizzaBoz.Domain.Models
{
    public class Pizza
    {
        public string Name {get; set;}
        public Crust Crust {get; set;}
        public Size Size {get; set;}
        public List<Topping> Toppings {get; set;}

        public Pizza(string name, string size, string crust, List<string> toppings)
        {   
            Size = Size;
            Crust = Crust;
            Topping a = new Topping(toppings);
            Toppings.Add(a);
            Name = name;
        }
    }
    
}
