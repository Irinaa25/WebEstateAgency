using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Interop.Data
{
    public class StreetDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public virtual DistrictDto District { get; set; }
        public int? DistrictId { get; set; }
        public virtual IEnumerable<EstateDto> Estates { get; set; }
    }
}
