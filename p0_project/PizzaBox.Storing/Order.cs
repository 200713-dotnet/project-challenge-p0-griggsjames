using System;
using System.Collections.Generic;

namespace PizzaBox.Storing
{
    public partial class Order
    {
        public Order()
        {
            Order1 = new HashSet<Order1>();
            Pizza = new HashSet<Pizza>();
        }

        public int OrderId { get; set; }
        public int UserId { get; set; }
        public int StoreId { get; set; }

        public virtual Store Store { get; set; }
        public virtual Users User { get; set; }
        public virtual ICollection<Order1> Order1 { get; set; }
        public virtual ICollection<Pizza> Pizza { get; set; }
    }
}
