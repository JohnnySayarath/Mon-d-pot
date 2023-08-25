using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo02RelationsBlog.Models
{
    internal class Blog
    {
        public int Id { get; set; }
        [Required]
        public string? Name { get; set; }
        [Required]
        public string? SiteUri { get; set; }
        public List<Post> Posts { get; set; } = new List<Post>();
        public BlogHeader Header { get; set; }
        // many to many SANS model pour la table intermédiaire
        //public List<Tag> Tags { get; set; } = new List<Tag>();

        // many to many AVEC model pour la table intermédiaire
        public List<BlogTag> BlogTags { get; set; } = new List<BlogTag>();
    }
}
