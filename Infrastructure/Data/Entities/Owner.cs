using System;
using System.Collections.Generic;

namespace Infrastructure.Data.Entities
{
    public partial class Owner
    {
        public Owner()
        {
            Properties = new HashSet<Property>();
        }

        public int Idowner { get; set; }
        public string Name { get; set; } = null!;
        public string Address { get; set; } = null!;
        public string Photo { get; set; } = null!;
        public string Birthday { get; set; } = null!;

        public virtual ICollection<Property> Properties { get; set; }
    }
}
