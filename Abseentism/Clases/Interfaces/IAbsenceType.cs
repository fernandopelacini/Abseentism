using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abseentism.Clases.Interfaces
{
    interface IAbsenceType
    {
        Task<IEnumerable<AbsenceType>> GetAll();
    }
}
