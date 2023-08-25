using Exercice02Hotel.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercice02Hotel.Models
{
    // Définition de la classe Client avec ses propriétés
    internal class Client
    {
        
        public int Id { get; set; }
        [Column("nom")]
        [Required]
        public string? Nom { get; set; }
        [Column("prenom")]
        [Required]
        public string? Prenom { get; set; }
        [Column("numero_de_telephone")]
        [Required]
        public string? NumeroTelephone { get; set; }
       
        public List<Reservation> Reservations { get; set; } 
    }
}