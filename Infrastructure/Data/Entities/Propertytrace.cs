using System;
using System.Collections.Generic;

namespace Infrastructure.Data.Entities
{
    public partial class Propertytrace
    {
        public int Idpropertytrace { get; set; }
        public string? Datesale { get; set; }
        public string? Name { get; set; }
        public string? Value { get; set; }
        public string? Tax { get; set; }
        public int? Idproperty { get; set; }

        public virtual Property? IdpropertyNavigation { get; set; }
    }
}
