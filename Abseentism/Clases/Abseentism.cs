using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abseentism.Clases
{
public class Abseentism
    {
        public int Id { get; set; }
        public int AbsenceTypeId { get; set; }
        public int IdAgent { get; set; }
        [DataType(DataType.Time)]
        public DateTime CurrentSchedule { get; set; }

        [DataType(DataType.Time)]
        public DateTime NewSchedule { get; set; }

        [DataType(DataType.Date)]
        public DateTime DateNewSchedule { get; set; }

        public string Observations { get; set; }

        [DataType(DataType.Date)]
        public DateTime AbsentDate { get; set; }

        [DataType(DataType.Date)]
        public DateTime LateDate { get; set; }

        [DataType(DataType.Time)]
        public DateTime LateOriginalTime { get; set; }

        [DataType(DataType.Time)]
        public DateTime LateActualTime { get; set; }

    }
}
