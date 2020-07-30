using System;
using System.Collections.Generic;

namespace PizzaBox.Domain.Models
{
    public class Size
    {
        public string SizeName;
        public double SizePrice;

        public Size()
        {

        }

        public string ChooseSize()
        {
            System.Console.WriteLine("Please choose a size:");
            System.Console.WriteLine("1 for small");
            System.Console.WriteLine("2 for medium");
            System.Console.WriteLine("3 for large");

            int SizeInp;
            int.TryParse(System.Console.ReadLine(), out SizeInp);
            var SizeName = "n";

            switch(SizeInp)
            {
                
                case 1:
                SizeName = "small";
                SizePrice = 10.00;
                break;

                case 2:
                SizeName = "medium";
                SizePrice = 12.00;
                break;

                case 3:
                SizeName = "large";
                SizePrice = 14.00;
                break;

                default:
                SizeName = "small";
                SizePrice = 10.00;
                break;

            }
            
        }

    }
}