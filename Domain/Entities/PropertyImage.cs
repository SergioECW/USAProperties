using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class PropertyImage
    {
        public Guid Idpropertyimage { get; set; }
        public byte[]? Files { get; set; }
        public string? Enabled { get; set; }
        public int? Idproperty { get; set; }

        public virtual Property? IdpropertyNavigation { get; set; }
    }
}
