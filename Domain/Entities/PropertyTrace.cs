using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class PropertyTrace
    {
        public int idpropertyTrace { get; set; }
        public string? dateSale { get; set; }
        public string? name { get; set; }
        public string? value { get; set; }
        public string? tax { get; set; }
        public int? idProperty { get; set; }

        public virtual Property? idPropertyNavigation { get; set; }
    }
}
