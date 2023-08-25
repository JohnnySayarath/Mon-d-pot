using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo02RelationsBlog.Models
{
    internal class Post
    {
        public int Id { get; set; }
        [Required]
        public string? Title { get; set; }
        [Required]
        public string? Content { get; set; }
        public DateTime PublishedOn { get; set; } = DateTime.Now;
        public bool Archived { get; set; } = false;

        // la propriété BlogId correspond à l'Id du blog lié au post
        // lorsque l'on passe cette propriété en nullable (int?), un post n'est pas forcément relié à un blog, il peut être indépendant
        public int BlogId { get; set; }

        // La propriété Blog correspond au blog lié (BlogId)
        // en BDD, on n'aura pas de colonne "Blog", seulement "BlogId"
        public Blog? Blog { get; set; }

        // les noms des propriétés sont importantes pour l'utilisation par défaut d'efcore
        // quand on a une propriété de type int nommée {Entité}Id, EFCore comprend que c'est une ForeignKey


        // si l'on voulait avoir des noms de propriétés différentes, on devrait passer par la Data Annotation ForeignKey
        // Elle prend en paramêtre le nom de la propriété qui contient l'entité Blog
        // https://learn.microsoft.com/en-us/ef/core/modeling/relationships/mapping-attributes#foreignkeyattribute

        //// exemple
        //[ForeignKey(nameof(Blog))]   // nameof(Blog) == "Blog" == nameof(Post.Blog)
        //public string BlogKey { get; set; }
    }
}
