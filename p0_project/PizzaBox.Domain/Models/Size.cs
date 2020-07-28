using System.Collections.Generic;

namespace PizzaBox.Domain.Models
{
    public class Size
    {
        public string SizeName {get;set;}

        public Size()
        {

        }

        public Size(string s)
        {
            SizeName = s;
        }

        public string ChooseSize()
        {
            System.Console.WriteLine("Please choose a size:");
            System.Console.WriteLine("1 for small");
            System.Console.WriteLine("2 for medium");
            System.Console.WriteLine("3 for large");

            int SizeInp;
            int.TryParse(System.Console.ReadLine(), out SizeInp);
            string SizeName = "n";

            switch(SizeInp)
            {
                case 1:
                SizeName = "small";
                break;

                case 2:
                SizeName = "small";
                break;

                case 3:
                SizeName = "small";
                break;
            }
            return SizeName;
        }
    }
}