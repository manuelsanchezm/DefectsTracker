using System.ComponentModel.DataAnnotations;

namespace DefectsTracker.Dtos
{
    public class DefectUpdateDto
    {
        [Required]
        [MaxLength(50)]
        public string Title { get; set; }
        public string Description { get; set; }
        public int? AssignedTo { get; set; }
        [Required]
        public int ReportedBy { get; set; }
        [Required]
        public byte Type { get; set; }
        [Required]
        public byte Priority { get; set; }
    }
}
