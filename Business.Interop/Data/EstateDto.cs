using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Interop.Data
{
    public class EstateDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public virtual ClientDto Client { get; set; }
        public int? ClientId { get; set; }
        public int Price { get; set; }
        public int Area { get; set; }
        public int YearOfConsruction { get; set; }
        public int RoomsCount { get; set; }
        public int FloorsCount { get; set; }
        public virtual StreetDto Street { get; set; }
        public int? StreetId { get; set; }
        public virtual EstateTypeDto EstateType { get; set; }
        public int? EstateTypeId { get; set; }
        public virtual IEnumerable<DealDto> Deals { get; set; }
    }
}
