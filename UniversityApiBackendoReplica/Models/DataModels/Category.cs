
using Microsoft.CodeAnalysis.CSharp.Syntax;
using System.ComponentModel.DataAnnotations;

namespace UniversityApiBackendoReplica.Models.DataModels
{
    public class Category : BaseEntity
    {
        [Required, StringLength(80)]
        public string Name { get; set; } = string.Empty;
        // existe una relacion con la tabla Curso
        // y quiere decir que una categoria puede tener varios cursos
        [Required(ErrorMessage = "Error desde la clase Category")]
        public ICollection<Course> Courses { get; set; } = new List<Course>();
    }
}
