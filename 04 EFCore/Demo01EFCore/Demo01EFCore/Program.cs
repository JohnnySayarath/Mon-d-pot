
using Demo01EFCore.Data;
using Demo01EFCore.Models;
using Microsoft.EntityFrameworkCore.ChangeTracking.Internal;

using var context = new ApplicationDbContext();

Student student = new Student()
{
    Firstname = "Johnny",
    Lastname = "Sayarath",
    Phone = "0781246544",
    Email = "johnnysayarath@hotmail.fr"
};

////CREATE
//// Ajout d'un étudiant
////context.Students.Add(student);            // préparation de l'ajout d'un étudiant (INSERT)
////context.SaveChanges();                    // exécution des commandes de modification préparées

//// READ
//Console.WriteLine("Récupération de tout les étudiants");
//List<Student> students = context.Students.ToList();              // Lister tout mes étudiants avec le ToList()
//foreach (var s in students)
//{
//    Console.WriteLine($"Etudiant : {s.Id}, {s.Firstname}, {s.Lastname}");
//}


//Console.WriteLine("Récupération par l'ID");

//Student student1 = context.Students.Find(1);                    // Trouve avec .Find(n) par le n° ID
//Console.WriteLine($"Etudiant {student1.Id}, {student1.Firstname}, {student1.Lastname}");


//Console.WriteLine("Récupération d'1 entité avec un prédicat (delegate qui retourne un booléen)");
//Student student2 = context.Students.FirstOrDefault(s => s.Lastname == "Sayarath");   
// équivalent :
//Student student2 = context.Students.FirstOrDefault(s => s.Id == 1"); 


//Console.WriteLine("Récupération de plusieurs entitées avec un prédicat (delegate qui retourne un bool)");
//List<Student> students = context.Students.Where(s => s.Lastname == "Sayarath").ToList();
//// Méthode avec le start with (commence par)
////List<Student> students = context.Students.Where(s => s.Lastname.StartsWith ("Saya")).ToList();
//foreach (var s in students)
//{
//    Console.WriteLine($"Etudiant : {s.Id}, {s.Firstname}, {s.Lastname}");
//};


// UPDATE

//Console.WriteLine("Récupération par l'Id");
//Student student2 = context.Students.Find(2);

//Console.WriteLine("Mise à jour de l'étudiant avec l'id 2 récupéré avant : ");

//student2.Firstname = "Mathieu";
//student2.Lastname = "Dupont";
//student2.Email = "mathieudupont@hotmail.fr";

//context.Students.Update(student2);
//context.SaveChanges();                                     // Toujours faire le saveChanges sinon rien ne change


// DELETE

Student student4 = context.Students.Find(1);
context.Students.Remove(student4);
context.SaveChanges();

