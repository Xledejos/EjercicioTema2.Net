
using System.ComponentModel.DataAnnotations;

namespace UniversityApiBackendoReplica.Models.DataModels
{
    public enum Level
    {
        Basic,
        Medio,
        Advance,
        Expert
    }
    public class Course : BaseEntity
    {
        [Required, StringLength(50)]
        public string Name { get; set; } = string.Empty;
        [Required, StringLength(50)]
        public string ShortDescription { get; set; } = string.Empty;
        [Required, StringLength(50)]
        public string Description { get; set; } = string.Empty;
        public Level Level { get; set; } = Level.Basic;
        // Generamos una lista de tipo ICollection,
        // la clase curso va estar asociado a la clase category,
        // y sera una nueva lista de la tabla Category
        // existe una relacion que un Course tiene varias Categories y lo mismo para Category
        [Required (ErrorMessage = "Error desde la clase Course")]
        public ICollection<Category> Categories { get; set; } = new List<Category>();
        [Required]
        public ICollection<Student> Students { get; set; } = new List<Student>();
        [Required]
        public Temary Temarys { get; set; } = new Temary();
    }
}
