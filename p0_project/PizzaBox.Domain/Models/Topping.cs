using System.Collections.Generic;

namespace PizzaBoz.Domain.Models
{
    public class Topping
    {
        public List<string> ToppingName {get;set;}
        
        public Topping(List<string> t)
        {
            ToppingName = t;
        }

    }
}