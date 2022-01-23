using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Interop.Data
{
    public class DistrictDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public virtual TownDto Town { get; set; }
        public int? TownId { get; set; }

        public virtual IEnumerable<StreetDto> Streets { get; set; }
    }
}
