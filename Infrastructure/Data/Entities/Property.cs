using System;
using System.Collections.Generic;

namespace Infrastructure.Data.Entities
{
    public partial class Property
    {
        public Property()
        {
            Propertytraces = new HashSet<Propertytrace>();
        }

        public int Idproperty { get; set; }
        public string Name { get; set; } = null!;
        public string Address { get; set; } = null!;
        public int Price { get; set; }
        public int Codeinternal { get; set; }
        public int Year { get; set; }
        public int Idowner { get; set; }

        public virtual Owner IdownerNavigation { get; set; } = null!;
        public virtual ICollection<Propertytrace> Propertytraces { get; set; }
    }
}
