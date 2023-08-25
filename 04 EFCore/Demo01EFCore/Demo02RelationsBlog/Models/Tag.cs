using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo02RelationsBlog.Models
{
    internal class Tag
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        
        // many to many SANS model pour la table intermédiaire
        //public List<Blog> Blogs { get; set; } = new List<Blog>();
        // many to many AVEC model pour la table intermédiaire
        public List<BlogTag> BlogTags { get; set; } = new List<BlogTag>();
    }
}
