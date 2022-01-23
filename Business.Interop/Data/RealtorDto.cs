using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Interop.Data
{
    public class RealtorDto
    {
        public int Id { get; set; }
        public string FullName { get; set; }
        public int Phone { get; set; }
        public int Experience { get; set; }
        public virtual IEnumerable<DealDto> Deals { get; set; }

    }
}
