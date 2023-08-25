using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo02RelationsBlog.Models
{
    internal class BlogHeader
    {
        public int Id { get; set; }
        public string? Content { get; set; }

        // lorsque l'on passe cette propriété en nullable (int?), un header n'est pas forcément relié à un blog, il peut être indépendant
        public int BlogId { get; set; }
        public Blog? Blog { get; set; }
    }
}
