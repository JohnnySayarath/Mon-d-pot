using Demo02RelationsBlog.Data;
using Demo02RelationsBlog.Models;
using Microsoft.EntityFrameworkCore;

using var db = new ApplicationDbContext();

// ONE TO MANY

////var blogList = db.Blogs.ToList();
//// lorsque l'on vien chercher nos blogs avec cette méthode, la liste de post n'est pas remplie
//// c'est une optimisation dans EFCore pour éviter les jointure trop couteuses en terme de ressources
//// pour les inclure, nous devront donc ajouter la méthode Include
////var blogList = db.Blogs.Include(b => b.Posts).ToList();

//var blogList = db.Blogs.OrderBy(b => b.Name).Include(b => b.Posts).ToList(); //trie par nom


//foreach (Blog blog in blogList)
//{
//    Console.WriteLine("--- Blog :");
//    Console.WriteLine(blog.Name);
//    Console.WriteLine(blog.SiteUri);
//    Console.WriteLine();

//    Console.WriteLine(blog.Posts.Count); // sans Include => 0 (pas de posts récupérés)

//    //foreach (Post post in blog.Posts) // sans Include, rien ne s'affiche
//    foreach (Post post in blog.Posts.OrderBy(p => p.PublishedOn)) // avec tri sur la date asc
//    //foreach (Post post in blog.Posts.OrderByDescending(p => p.PublishedOn)) // avec tri sur la date desc
//    {
//        Console.WriteLine($"   - Post {post.Id}:");
//        Console.WriteLine("   " + post.Title);
//        Console.WriteLine("   BlogId = " + post.BlogId);
//        Console.WriteLine("   " + post.Content);
//        Console.WriteLine();
//    }
//}



//List<Post> posts = db.Posts.ToList();

//foreach (Post post in posts)
//{
//    Console.WriteLine("--- Post :");
//    Console.WriteLine(post.Title);
//    Console.WriteLine(post.Content);
//    Console.WriteLine(post.BlogId);
//    Console.WriteLine(post.Blog.Name); // le include n'est pas nécessaire quand on est dans le sens inverse (une seule entité et non une liste)
//    Console.WriteLine();
//}


// ONE TO ONE

//// Ajout d'un header

//db.BlogHeaders.Add(new BlogHeader()
//{
//    Content = "Bienvenue sur le skyblog de jenn",
//    BlogId = 1
//});
//db.SaveChanges();
//// ATTENTION, cela ne marchera que la première fois, après notre blog a déjà un header associé !




//var blogDeJenn = db.Blogs.Where(b => b.Name.Contains("Jennifer")).FirstOrDefault();
//var blogDeJenn = db.Blogs.FirstOrDefault(b => b.Name.Contains("Jennifer"));
// attention pour les requêtes ci-dessus Header => null, il faut l'include

//var blogDeJenn = db.Blogs.Include(b => b.Header).FirstOrDefault(b => b.Name.Contains("Jennifer"));

//Console.WriteLine(blogDeJenn.Header.Content);


// MANY TO MANY

var listeBlogPourTag = db.Blogs.ToList();

Tag tagAnimaux = new Tag()
{
    Name = "Ceci est un blog qui parle d'animaux"
};

// ajout d'une relation many to many entre tag et blog


// SANS model pour la table intermédiaire

//tagAnimaux.Blogs.Add(listeBlogPourTag[0]); // on ajoute un blog dans la liste Blogs du tag
//db.Tags.Add(tagAnimaux); // on ajoute le tag à la db
//db.SaveChanges();


// AVEC model pour la table intermédiaire

//db.Tags.Add(tagAnimaux); // on ajoute le tag à la db
//db.SaveChanges();

var monTag = db.Tags.FirstOrDefault();

BlogTag blogTag = new BlogTag()
{
    BlogId = listeBlogPourTag[0].Id,
    TagId = monTag.Id
};

db.BlogTags.Add(blogTag);


BlogTag blogTag2 = new BlogTag()
{
    BlogId = 2,
    TagId = 1
};

db.BlogTags.Add(blogTag2);
db.SaveChanges();