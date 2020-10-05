using System;
using System.Collections.Generic;

namespace DefectsTracker.EF
{
    public partial class Defect
    {
        public int Id { get; set; }
        public string DefectTitle { get; set; }
        public byte DefectType { get; set; }
        public byte DefectPriority { get; set; }
        public int? AssignedUser { get; set; }
        public int ReportedUser { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime ModifiedDate { get; set; }
    }
}
