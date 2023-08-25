using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo01EFCore.Models
{
    internal class Student
    {
        //La data annotation "Key" sert à préciser que la prop suivante correspond à la clé primaire de la table
        // Elle est facultative dans le cas ou la clé correspond à "int Id", c'est le comportement par défaut de
        // EFCore

        // [Key]
        public int Id { get; set; }

        // Required permet de dire qu'un champ/colonne est requis dans notre base de données
        // cela aura pour effet de mettre le champ en NOT NULL à la création
        [Required]
        public string? Firstname { get; set; }
        [Required]
        public string? Lastname { get; set; }
        public string? Phone { get; set; }
        public string? Email { get; set; }

    }
}
