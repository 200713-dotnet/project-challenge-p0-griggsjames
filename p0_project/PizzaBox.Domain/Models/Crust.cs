namespace PizzaBox.Domain.Models
{
    public class Crust
    {
        public string CrustName {get;set;}

        public Crust()
        {

        }
        
        public Crust(string c)
        {
            CrustName = c;
        }

        public string ChooseCrust()
        {
            System.Console.WriteLine("Please choose a crust:");
            System.Console.WriteLine("1 for Regular");
            System.Console.WriteLine("2 for Handtossed");
            System.Console.WriteLine("3 for Stuffed");

            int CrustInp;
            int.TryParse(System.Console.ReadLine(), out CrustInp);
            string CrustName = "n";

            switch(CrustInp)
            {
                case 1:
                CrustName = "Regular";
                break;

                case 2:
                CrustName = "Handtossed";
                break;

                case 3:
                CrustName = "Stuffed";
                break;
            }
            return CrustName;
        }
    }
}