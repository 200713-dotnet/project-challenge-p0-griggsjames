using System.Collections.Generic;
using System;

namespace PizzaBox.Domain.Models
{
    public class User
    {   
        public List<Order> Orders { get; set; }
        
        public User()
        {
            Orders = new List<Order>();
            
        }

        // public User(string u)
        // {
        //     Name = u;
        // }

        // void ViewOrderHist()
        // {

        // }
        void DailyRestrict()
        {
            
        }
        void TwoHrRestrict()
        {

        }

        public int UserLogIn()
        {
            Console.WriteLine("");
            Console.WriteLine("Please put in your User ID#:");
            int UserId;
            int.TryParse(Console.ReadLine(), out UserId);
            return UserId;
        }

    }
}