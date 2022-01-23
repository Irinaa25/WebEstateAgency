using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Enties
{
    public class Deal
    {
        public int Id { get; set; }
        public virtual Client Client { get; set; }
        public int? ClientId { get; set; }
        public virtual Estate Estate { get; set; }
        public int? EstateId { get; set; }
        public virtual Realtor Realtor { get; set; }
        public int? RealtorId { get; set; }

        public DateTime Date { get; set; }
        public int Sum { get; set; }

    }
}
