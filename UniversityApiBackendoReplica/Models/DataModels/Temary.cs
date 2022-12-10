using System.ComponentModel.DataAnnotations;

namespace UniversityApiBackendoReplica.Models.DataModels
{
    public class Temary : BaseEntity
    {
        [Required]
        public string Chapter { get; set; } = string.Empty;
        public int CourseId { get; set; }
        public virtual Course Course { get; set; } = new Course();
    }
}
