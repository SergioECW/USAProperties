using System;
using System.Collections.Generic;

namespace Infrastructure.Data.Entities
{
    public partial class Propertyimage
    {
        public Guid Idpropertyimage { get; set; }
        public byte[]? Files { get; set; }
        public string? Enabled { get; set; }
        public int? Idproperty { get; set; }

        public virtual Property? IdpropertyNavigation { get; set; }
    }
}
