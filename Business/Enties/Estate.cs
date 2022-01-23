using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Enties
{
    public class Estate
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public virtual Client Client { get; set; }
        public int? ClientId { get; set; }
        public int Price { get; set; }
        public int Area { get; set; }
        public int YearOfConsruction { get; set; }
        public int RoomsCount { get; set; }
        public int FloorsCount { get; set; }
        public virtual Street Street { get; set; }
        public int? StreetId { get; set; }
        public virtual EstateType EstateType { get; set; }
        public int? EstateTypeId { get; set; }
       public virtual IEnumerable<Deal> Deals { get; set; }

    }
}
