using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Exercice02Hotel;

namespace Exercice02Hotel.Models
{
    // Définition de la classe Réservation avec ses propriétés
    internal class Reservation
    {
        public int Id { get; set; }
        public StatutReservation Statut { get; set; }
        
        public int ClientId { get; set; }
        public Client Client { get; set; }


        public List<ReservationChambre> ReservationChambres { get; set; } = new List<ReservationChambre>();

    }
    // Énumération pour les différents statuts d'une réservation
    public enum StatutReservation
    {
        Prevue,
        EnCours,
        Finie,
        Annulee
    }
}