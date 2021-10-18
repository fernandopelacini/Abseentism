using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abseentism.Data.ViewModels
{
  public  class FullAgentViewModel
    {
        public int Id { get; set; }
        public string AvayaId { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public int CountryId { get; set; }
        public int TeamId { get; set; }
        public string Pais { get; set; }
        public string TeamName { get; set; }
    }
}
