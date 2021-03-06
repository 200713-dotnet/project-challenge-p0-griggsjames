﻿using System;
using System.Collections.Generic;

namespace PizzaBox.Storing
{
    public partial class Pizza1
    {
        public Pizza1()
        {
            Pizza = new HashSet<Pizza>();
            PizzaTopping = new HashSet<PizzaTopping>();
        }

        public int PizzaId { get; set; }
        public int CrustId { get; set; }
        public int SizeId { get; set; }
        public string Name { get; set; }

        public virtual Crust Crust { get; set; }
        public virtual Size Size { get; set; }
        public virtual ICollection<Pizza> Pizza { get; set; }
        public virtual ICollection<PizzaTopping> PizzaTopping { get; set; }
    }
}
