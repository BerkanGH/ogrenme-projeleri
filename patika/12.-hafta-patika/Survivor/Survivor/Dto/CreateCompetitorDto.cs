using System.ComponentModel.DataAnnotations;

namespace Survivor.Dto
{
    public class CreateCompetitorDto
    {
        [Required]
        public string FirstName { get; set; } = "";
        
        [Required]
        public string LastName { get; set; } = "";
       
        [Required]
        public int CategoryId { get; set; }
    }
}
