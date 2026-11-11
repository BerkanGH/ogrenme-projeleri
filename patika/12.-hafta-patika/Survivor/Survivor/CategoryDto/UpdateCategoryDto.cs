using System.ComponentModel.DataAnnotations;

namespace Survivor.CategoryDto
{
    public class UpdateCategoryDto
    {
        [Required]
        public string Name { get; set; }
    }
}
