using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Enties
{
    public class Street
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public virtual District District { get; set; }
        public int? DistrictId { get; set; }

        public virtual IEnumerable<Estate> Estates { get; set; }

    }
}
