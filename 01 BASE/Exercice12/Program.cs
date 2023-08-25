Console.WriteLine("--- Dans quelle catégorie mon enfant est il ...? ---");
Console.Write("Entrez l'age de l'enfant : ");
int age = Convert.ToInt32(Console.ReadLine());

// possibilité d'ajouter un contrôle de saisie pour un age correct (Tryparse, <125 et >0)

if (age < 3)
    Console.WriteLine("Vous êtes trop jeune");
else if (age <= 6)
    Console.WriteLine("Baby");
else if (age <= 8)
    Console.WriteLine("Poussin");
else if (age <= 10)
    Console.WriteLine("Pupille");
else if (age <= 12)
    Console.WriteLine("Minime");
else if (age <= 17)
    Console.WriteLine("Cadet");
else
    Console.WriteLine("Vous êtes trop vieux");
