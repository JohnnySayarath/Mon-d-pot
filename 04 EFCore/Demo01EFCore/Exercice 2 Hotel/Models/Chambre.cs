
using Exercice02Hotel.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercice02Hotel.Models
{
    // Définition de la classe Chambre avec ses propriétés
    internal class Chambre
    {
        [Key]
        public int ChambreNumero { get; set; }
        [Required]
        public int NombreLits { get; set; }
        [Precision(14,2)]
        [Required]
        public decimal Tarif { get; set; }
        [Required]
        public StatutChambre Statut { get; set; }
      

        // Énumération pour les différents statuts d'une chambre

        public List<ReservationChambre> ReservationChambres { get; set; } = new List<ReservationChambre>();
        public enum StatutChambre
        {
            Libre,
            Occupe,
            Nettoyage
        }
    }
}