using Abseentism.Clases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abseentism.Data.Mappers
{
    public static class AbsenceTypeMapper
    {
        public static AbsenceType Map(AbsenceTypes dto)
        {
            return new AbsenceType
            {
                ID = dto.id,
                Name = dto.name,
                Code = dto.code
            };
        }

        public static IEnumerable<AbsenceType> Map(IEnumerable<AbsenceTypes> dto)
        {
            List<AbsenceType> absenceTypeList = new List<AbsenceType>();

            foreach (var item in dto)
            {
               var data =  new AbsenceType
                {
                    ID = item.id,
                    Name = item.name,
                    Code = item.code
                };
                absenceTypeList.Add(data);
            }
            return absenceTypeList;


        }

    }
}
