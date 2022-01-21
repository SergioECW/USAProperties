using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Property
    {
        public Property()
        {
            PropertyTraces = new HashSet<PropertyTrace>();
        }
        public int id { get; set; }
        public string name { get; set; } = null!;
        public string address { get; set; } = null!;
        public int price { get; set; }
        public int codeInternal { get; set; }
        public int Year { get; set; }
        public int idOwner { get; set; }

        public virtual Owner idOwnerNavigation { get; set; } = null!;

        public virtual ICollection<PropertyTrace> PropertyTraces{ get; set; }
    }
}
