using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Interop.Data
{
    public class ClientDto
    {
        public int Id { get; set; }
        public string FullName { get; set; }
        public int Phone { get; set; }
        public virtual IEnumerable<EstateDto> Estates { get; set; }
        public virtual IEnumerable<DealDto> Deals { get; set; }
    }
}
