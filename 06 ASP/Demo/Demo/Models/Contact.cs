using System.ComponentModel.DataAnnotations;

namespace Demo.Models
{
    public class Contact
    {
        public int Id { get; set; }
        [Display(Name = "Prénom")]
        public string? Nom { get; set; }
        public string? Prenom { get; set; }
        public string? Email { get; set; }
        [Display(Name = "Numéro de téléphone")]
        public string Telephone { get; set; }
    }
}
