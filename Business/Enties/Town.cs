using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Enties
{
    public class Town
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public virtual IEnumerable<District> Districts { get; set; }
    }
}
