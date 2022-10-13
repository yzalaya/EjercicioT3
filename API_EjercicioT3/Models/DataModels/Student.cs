using System.ComponentModel.DataAnnotations;

namespace API_EjercicioT3.Models.DataModels
{
    public class Student : BaseEntity
    {
        [Required]
        public string FirtsName { get; set; } = string.Empty;
        [Required]
        public string LastName { get; set; } = string.Empty;
        [Required]
        public DateTime DoB { get; set; }

        public ICollection<Course> Courses { get; set; } = new List<Course>();
    }
}
