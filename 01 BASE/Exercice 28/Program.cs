Console.WriteLine("--- Trouver le nombre mystère ---\n");
Random randomNbr = new Random();
int random = randomNbr.Next(1, 50);
int play = 0;
int userInput, count = 0;
while (play != random)
{
    Console.Write("\tVeuillez saisir un nombre : ");
    while (!int.TryParse(Console.ReadLine(), out userInput) || userInput <1 || userInput >50)
    count++;

    if (random == userInput)
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine($"\nBravo vous avez trouver le chiffre {random}");
        Console.WriteLine($"\nVous avez trouver en {count} coups !");
        Console.ResetColor();
    }
    else if (userInput < random)
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("\t\tLe nombre mystère est plus grand");
        Console.ResetColor();
    }
    else if (userInput > random)
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("\t\tLe nombre mystère est plus petit");
        Console.ResetColor();
    }
}