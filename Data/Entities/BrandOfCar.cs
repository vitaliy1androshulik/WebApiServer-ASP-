using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Entities
{
    public class BrandOfCar
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public ICollection<Mercedes> Mercedeses { get; set; }
    }
}
