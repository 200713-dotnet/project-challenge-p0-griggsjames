using System;

namespace PizzaBox.Domain.Models
{
    public class Crust
    {
        public string CrustName;
        public double CrustPrice;
        
        public Crust ()
        {
        }

        public string ChooseCrust()
        {
            System.Console.WriteLine("Please choose a crust:");
            System.Console.WriteLine("1 for Regular");
            System.Console.WriteLine("2 for Handtossed");
            System.Console.WriteLine("3 for Stuffed");

            int CrustInp;
            int.TryParse(System.Console.ReadLine(), out CrustInp);
            

            

            switch(CrustInp)
            {
                case 1:
                
                CrustName = "Regular";
                CrustPrice=1.00;
                break;

                case 2:
                CrustName = "Handtossed";
                CrustPrice=2.00;
                break;

                case 3:
                CrustName = "Stuffed";
                CrustPrice=3.00;
                break;

                default:
                CrustName = "Regular";
                CrustPrice=1.00;
                break;
            }
            return CrustName;
        }

    }
}