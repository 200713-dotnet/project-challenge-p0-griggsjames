using System.Collections.Generic;
using PizzaBox.Domain.Models;
using System.Text;

namespace PizzaBox.Domain.Models
{
    public class Pizza
    {
        public string Size {get;}
        public string Crust {get;}
        public List<string> _toppings = new List<string>();
        public double Price {get;}
        public string Name {get;}

        public List<string> Toppings
        {
            get
            {
                return _toppings;
            }
        }        
        public Pizza(string name, string size, string crust, List<string> toppings, double price)
        {   
            Size = size;
            Crust = crust;
            Toppings.AddRange(toppings);
            Name = name;
            Price = price;
        }

        public override string ToString()
        {
            var StrBuild = new StringBuilder();

            foreach(var toppin in Toppings)
            {
                StrBuild.Append(toppin + ", \n");
            }
            return ($"\n Size=  {Size}\n Crust=  {Crust}\n Toppings=  {Toppings}");
        }

    }
    
}
