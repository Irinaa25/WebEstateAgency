using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Interop.Data
{
    public class DealDto
    {
        public int Id { get; set; }
        public virtual ClientDto Client { get; set; }
        public int? ClientId { get; set; }
        public virtual EstateDto Estate { get; set; }
        public int? EstateId { get; set; }
        public virtual RealtorDto Realtor { get; set; }
        public int? RealtorId { get; set; }

        public DateTime Date { get; set; }
        public int Sum { get; set; }
    }
}
