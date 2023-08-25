using Exercice02Hotel.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Exercice02Hotel;

namespace Exercice02Hotel.Models;

internal class ReservationChambre
{
    //public int Id { get; set; }

    [ForeignKey(nameof(Chambre))]
    public int ChambreNumero { get; set; }
    public Chambre? Chambre { get; set; }

    public int ReservationId { get; set; }
    public Reservation? Reservation { get; set; }
}
