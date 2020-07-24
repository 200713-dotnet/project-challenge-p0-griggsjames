using System.Collections.Generic;

namespace PizzaBox.Domain.Models
{
    public class Store
    {
        public static void StoreMenu()
        {
            System.Console.WriteLine("Welcome to your store menu!");
            System.Console.WriteLine();
            System.Console.WriteLine("Please enter your store ID#:");
            
            int store_input;
            int.TryParse(System.Console.ReadLine(), out store_input);

            switch(store_input)
            {
                case 1:  // set to take store ID# as input instead of 1
                    System.Console.WriteLine("Please select an option from the following menu:");
                    System.Console.WriteLine("Press 1 in order to see store orders");
                    System.Console.WriteLine("Press 2 in order to see total revenue for the week");

                    int case1_input;
                    int.TryParse(System.Console.ReadLine(), out case1_input);

                        switch(case1_input)
                        {
                            case 1:
                                //return list of all store orders
                                break;

                            case 2:
                                //return total of data stored in revenue
                                break;
                        }
                    break;

                case 2: //set to take store ID#
                    System.Console.WriteLine("Please select an option from the following menu:");
                    System.Console.WriteLine("Press 1 in order to see store orders");
                    System.Console.WriteLine("Press 2 in order to see total revenue for the week");

                    int case2_input;
                    int.TryParse(System.Console.ReadLine(), out case2_input);

                        switch(case2_input) 
                        {
                            case 1:
                                //return list of all store orders
                                break;

                            case 2:
                                //return total of data stored in revenue
                                break;
                        }
                    break;

            }


        }

        public static void StoreSelectMenu()
        {
            //Get storeIDs from table
            // set variables to StoreIds
            System.Console.WriteLine("Choose the store you would like to place an order at");
            System.Console.WriteLine("");
            //System.Console.WriteLine(Enter 1 for StoreID1)
            //System.Console.WriteLine(Enter 2 for StoreID2)

            int StoreSelectInp;
            int.TryParse(Console.ReadLine(), out StoreSelectInp);

            switch(StoreSelectInp)
            {
                case 1:
                //return StoreId1 variable?
                break;

                case 2:
                //return StoreId2 variable?
                break;
            }
        }
    }
}