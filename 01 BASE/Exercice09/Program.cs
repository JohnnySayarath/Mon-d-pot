Console.WriteLine("Entrez le capital de départ (en euros) :");
float capitalDepart = float.Parse(Console.ReadLine());
Console.WriteLine("Entrez le taux d'intérêts (en %) :");
float txInt = float.Parse(Console.ReadLine());
Console.WriteLine("Entrez la durée de l'épargne (en années) :");
float durree = float.Parse(Console.ReadLine());

double montantInterets = Math.Round(capitalDepart * Math.Pow(1 + txInt / 100, durree) - capitalDepart, 2);
double capitalFinal = Math.Round(montantInterets + capitalDepart, 2);

Console.WriteLine($"Le montant des intérets sera de {montantInterets} euros après {durree} ans");
Console.WriteLine($"Le capital final sera de {capitalFinal}");
