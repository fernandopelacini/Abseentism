using Abseentism.Clases.Interfaces;
using Abseentism.Data;
using Abseentism.Data.Mappers;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abseentism.Clases.Repository
{
public   class AbsenceTypeRepository:IAbsenceType
    {
        private AbseentismEntities _context = new AbseentismEntities();

        public async Task<IEnumerable<AbsenceType>> GetAll()
        {
            try
            {
                //var absencetypes = await _context.AbsenceTypes.ToListAsync();
                return AbsenceTypeMapper.Map(await _context.AbsenceTypes.ToListAsync());
            }
            catch (Exception )
            {
                return null;
               //LOG EXCPETION
            }
        }
    }
}
