/* Nombre entier */
Console.Write("Veuillez saisir un nombre entier : ");
int premierNombre = int.Parse(Console.ReadLine());  // équivalent: Convert.ToInt32(Console.ReadLine());
Console.Write("Veuillez saisir un nombre entier : ");
int deuxiemeNombre = int.Parse(Console.ReadLine());
int somme = premierNombre + deuxiemeNombre;
Console.WriteLine($"La somme de ces deux nombres est : {somme}");


/* Nombre réel */
Console.Write("Veuillez saisir un nombre réel : ");
float premierNombreFloat = float.Parse(Console.ReadLine());
Console.Write("Veuillez saisir un nombre réel : ");
float deuxiemeNombreFloat = float.Parse(Console.ReadLine());
float sommeFloat = premierNombreFloat + deuxiemeNombreFloat;
Console.WriteLine($"La somme de ces deux nombres est : {sommeFloat}");

