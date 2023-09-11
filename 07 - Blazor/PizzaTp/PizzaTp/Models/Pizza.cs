namespace PizzaTp.Models
{
    public class Pizza
    {
        public int Id { get; set; }
        public string? ImageUrl { get; set; }
        public string? Titre { get; set; }
        public string? Description { get; set; }
        public decimal? Prix { get; set; }
    }
}
