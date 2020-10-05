using System;
using System.ComponentModel.DataAnnotations;

namespace DefectsTracker.Models
{
    public class Defect
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [MaxLength(50)]
        public string Title { get; set; }

        public string Description { get; set; }
        [Required]
        public byte Type { get; set; }
        [Required]
        public byte Priority { get; set; }
        public int? AssignedTo { get; set; }
        [Required]
        public int ReportedBy { get; set; }
        [Required]
        public DateTime Created { get; set; }
        [Required]
        public DateTime Modified { get; set; }
    }
}
