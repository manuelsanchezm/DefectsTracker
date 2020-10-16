using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DefectsTracker.Dtos
{
    public class DefectReadDto : DefectDto
    {
        public int Id { get; set; }
        //public string Title { get; set; }
        //public string Description { get; set; }
        //public byte Type { get; set; }
        //public byte Priority { get; set; }
        //public int? AssignedTo { get; set; }
        //public int ReportedBy { get; set; }
        public DateTime Created { get; set; }
        public DateTime Modified { get; set; }
    }
}
