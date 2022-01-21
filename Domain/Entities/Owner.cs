using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Owner
    {
        public Owner()
        {
            Properties = new HashSet<Property>();
        }
        public int idOwner { get; set; }
        public string name { get; set; } = null!;
        public string adress { get; set; } = null!;

        public string photo { get; set; } = null!;
        public string birthday { get; set; } = null!;

        public virtual ICollection<Property> Properties{ get; set; }
    }
}
