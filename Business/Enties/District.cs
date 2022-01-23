using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Enties
{
    public class District
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public virtual Town Town { get; set; }
        public int? TownId { get; set; }

        public virtual IEnumerable<Street> Streets { get; set; }
    }
}
