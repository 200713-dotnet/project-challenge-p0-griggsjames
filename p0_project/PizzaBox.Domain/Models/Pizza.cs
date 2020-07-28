using System.Collections.Generic;
using PizzaBox.Domain.Models;

namespace PizzaBox.Domain.Models
{
    public class Pizza
    {
        public string Name {get; set;}
        public Crust Crust {get; set;}
        public Size Size {get; set;}
        public List<string> Toppings {get; set;}

        public Pizza()
        {

        }

        public Pizza(string name, string size, string crust, List<string> toppings)
        {   
            Size = Size;
            Crust = Crust;
            Toppings = new List<string>();
            Toppings.AddRange(toppings);
            Name = name;
        }
    }
    
}
