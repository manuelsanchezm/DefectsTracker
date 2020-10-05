using System;

namespace DefectsTracker.Models
{
    public class Defect
    {
        public int Id { get; set; }

        public string Title { get; set; }

        public string Description { get; set; }

        public byte DefectType { get; set; }

        public byte DefectPriority { get; set; }
        public int? AssignedTo { get; set; }

        public int ReportedBy { get; set; }

        public DateTime Created { get; set; }

        public DateTime Modified { get; set; }
    }
}
