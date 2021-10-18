using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abseentism.Clases.Interfaces
{
public    interface ICountry
    {
       Task<IEnumerable<Country>> GetCountries();
        Task<bool> AddCountry(string country);
        Task<bool> EditCountry(Country country);
    }
}
