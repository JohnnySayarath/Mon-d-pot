Console.WriteLine("Saisir la longueur du premier côté (cm) :");
float cote1 = float.Parse(Console.ReadLine());
Console.WriteLine("Saisir la longueur du deuxième côté (cm) :");
float cote2 = float.Parse(Console.ReadLine());

Console.WriteLine($"Hypothénuse : {Math.Sqrt(Math.Pow(cote1,2) + Math.Pow(cote2, 2))} cm");

double hyp = Math.Sqrt(Math.Pow(cote1, 2) + Math.Pow(cote2, 2));
Console.WriteLine($"Hypothénuse : {Math.Round(hyp,2)} cm");
//Console.WriteLine($"Hypothénuse : {Math.Floor(hyp)} cm");
//Console.WriteLine($"Hypothénuse : {Math.Ceiling(hyp)} cm");
