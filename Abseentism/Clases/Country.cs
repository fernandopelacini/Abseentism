using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abseentism.Clases
{
    public class Country
    {
        public int Id { get; set; }
        public string Pais { get; set; }
        public IEnumerable<Teams> Teams { get; set; }
    }
}
