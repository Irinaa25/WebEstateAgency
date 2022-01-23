using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Interop.Data
{
    public class TownDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public virtual IEnumerable<DistrictDto> Districts { get; set; }
    }
}
