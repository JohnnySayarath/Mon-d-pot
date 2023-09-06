using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TPASPCaisse.Models
{
    [Table("product")]
    public class Product
    {
        [Column("id")]
        public int Id { get; set; }
        [Column("name")]
        [Display(Name = "Nom")]
        [Required(ErrorMessage = "Le nom est requis.")]
        [StringLength(30, MinimumLength = 3, ErrorMessage = "Le nom doit être compris entre 3 et 30 caractères.")]
        [RegularExpression(@"[A-Z][a-zA-Z \-]*", ErrorMessage = "Nom invalide.")]

        public string Name { get; set; }
        [Column("description")]
        public string? Description { get; set; }
        [Column("price")]
        [Display(Name = "Prix")]
        [Required(ErrorMessage = "Le prix est requis.")]
        [Range(0,100)]
        public decimal Price { get; set; }
        [Column("quantity")]
        [Display(Name = "Quantité")]
        [Required(ErrorMessage = "La quantité est requise.")]
        [Range(0, 100)]
        [Precision(10,2)]
        public int Quantity { get; set; }
        public string? ImageUrl { get; set; }
        public int CategoryId { get; set; }
        public Category? Category { get; set; }

    }
}
