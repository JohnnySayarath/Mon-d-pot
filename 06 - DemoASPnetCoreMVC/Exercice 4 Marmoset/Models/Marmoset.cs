using System.ComponentModel.DataAnnotations;

namespace Exercice_4_Marmoset.Models
{
    public class Marmoset
    {
        public int Id { get; set; }
        [Display(Name = "Nom du ouistiti")]
        public string? Name { get; set; }
        [Display(Name = "Age du ouistiti")]
        public int Age { get; set; }
    }
}
