namespace Survivor.CategoryDto
{
    public class CategoryDto
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public ICollection<CompetitorDto> Competitors { get; set; }
    }
}
