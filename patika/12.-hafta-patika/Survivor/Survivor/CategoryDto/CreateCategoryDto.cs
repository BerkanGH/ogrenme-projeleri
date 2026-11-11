using System.ComponentModel.DataAnnotations;

namespace Survivor.CategoryDto
{
    public class CreateCategoryDto
    {
        [Required(ErrorMessage = "İsim alanı zorunludur!")]
        public string Name { get; set; }

    }
}
