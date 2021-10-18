using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abseentism.Clases
{
    public class Agent
    {
        public int Id { get; set; }
        public string AvayaId { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public int CountryId { get; set; }
        public string FullName
        {
            get { return Surname + ", " + Name; }
        }
    public int TeamId { get; set; }
}
}
