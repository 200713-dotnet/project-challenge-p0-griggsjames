﻿using System;
using System.Collections.Generic;

namespace PizzaBox.Storing
{
    public partial class Users
    {
        public Users()
        {
            Order = new HashSet<Order>();
        }

        public int UserId { get; set; }
        public string Name { get; set; }

        public virtual ICollection<Order> Order { get; set; }
    }
}
