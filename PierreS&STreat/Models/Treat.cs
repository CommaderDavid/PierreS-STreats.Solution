using System.Collections.Generic;
using System;

namespace PierreS_STreat.Models
{
    public class Treat
    {
        public int TreatId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public virtual ApplicationUser User { get; set; }
        public virtual ICollection<FlavorTreat> Flavors { get; }

        public Treat()
        {
            this.Flavors = new HashSet<FlavorTreat>();
        }
    }
}