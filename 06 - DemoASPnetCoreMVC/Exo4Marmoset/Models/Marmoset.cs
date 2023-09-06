using System.ComponentModel.DataAnnotations.Schema;

namespace Exo4Marmoset.Models
{
    [Table("marmosets")]
    public class Marmoset
    {
        [Column("id")]
        public int Id { get; set; }
        [Column("nom")]
        public string? Name { get; set; }
        [Column("age")]
        public int? Age { get; set; }
    }


}
