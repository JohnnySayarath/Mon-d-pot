using System.ComponentModel.DataAnnotations;

namespace DemoASPnetCoreMVC.Models
{
    public class Contact
    {
        public int Id { get; set; }
        [Display(Name = "Prénom")] // par défaut le display correspond au nom de la propriété
        public string? FirstName { get; set; }
        [Display(Name = "Nom")]
        public string? LastName { get; set; }
        [Display(Name = "Adresse Mail")]
        public string? Email { get; set; }
        [Display(Name = "Numéro de téléphone")]
        public string? Phone { get; set; }
    }
}
