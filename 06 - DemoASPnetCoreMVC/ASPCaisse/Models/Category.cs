using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Xml.Linq;

namespace TPASPCaisse.Models
{
    [Table("category")]
    public class Category
    {
        [Column("id")]
        public int Id { get; set; }
        [Column("name")]
        [Display(Name = "Nom")]
        [Required(ErrorMessage = "Le nom est requis.")]
        [StringLength(30, MinimumLength = 3, ErrorMessage = "Le nom doit être compris entre 3 et 30 caractères.")]
        [RegularExpression(@"[A-Z][a-zA-Z \-]*", ErrorMessage = "Nom invalide.")]
        public string Name { get; set; }
        public List<Product> Products { get; set; } = new List<Product>();
    }
}
