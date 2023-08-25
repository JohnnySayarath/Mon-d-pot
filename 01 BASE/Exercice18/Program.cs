Console.WriteLine("--- Dans quelle catégorie mon enfant est il ...? ---");
Console.Write("Entrez l'age de l'enfant : ");
string ageString = Console.ReadLine();

if (!int.TryParse(ageString, out int age))
    Console.WriteLine("Saisie invalide, un entier est demandé");
else
    switch (age)
    {
        case >= 0 and < 3:
            Console.WriteLine("Vous êtes trop jeune");
            break;
        case <= 6:
            Console.WriteLine("Baby");
            break;
        case <= 8:
            Console.WriteLine("Poussin");
            break;
        case <= 10:
            Console.WriteLine("Pupille");
            break;
        case <= 12:
            Console.WriteLine("Minime");
            break;
        case <= 17:
            Console.WriteLine("Cadet");
            break;
        case <= 122:
            Console.WriteLine("Vous êtes trop vieux");
            break;
        default:
            Console.WriteLine("Age invalide !");
            break;
    }