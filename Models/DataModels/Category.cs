using System.ComponentModel.DataAnnotations;

namespace backendDotnet.Models.DataModels
{
    public class Category : BaseEntity
    {
        [Required]
        public string Name { get; set; } = string.Empty;

        [Required]
        public ICollection<Course> courses { get; set; } = new List<Course>();


    }
}
