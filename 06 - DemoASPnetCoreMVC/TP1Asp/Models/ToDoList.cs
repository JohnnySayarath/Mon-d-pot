using System.ComponentModel.DataAnnotations.Schema;

namespace TP1Asp.Models
{
    [Table("todolist")]
    public class ToDoList
    {
        [Column("id")]
        public int Id { get; set; }
        [Column("titre_task")]
        public string TitleTask { get; set; }
        [Column("desc")]
        public string Desc { get; set; }
    }
}
