using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DefectsTracker.Dtos
{
    public abstract class DefectDto
    {
        [Required]
        [MaxLength(50)]
        public string Title { get; set; }
        public string Description { get; set; }
        public int? AssignedTo { get; set; }
        [Required]
        public int? ReportedBy { get; set; }
        [Required]
        public byte? Type { get; set; }
        [Required]
        public byte? Priority { get; set; }

    }
}
