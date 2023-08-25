using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Exercice_1_EFCore.Models
{
    internal class Adress
    {
        public int Id { get; set; }
        [Required]
        public string? Numero_voie { get; set; }
        public string? Complement { get; set; }
        [Required]
        public string? Intitule_voie { get; set; }
        [Required]
        public string? Commune { get; set; }
        [Required]
        public string? CodePostal { get; set; }

    }
}
