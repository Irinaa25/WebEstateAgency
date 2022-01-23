using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Enties
{
    public class EstateType
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public virtual IEnumerable<Estate> Estates { get; set; }
    }
}
