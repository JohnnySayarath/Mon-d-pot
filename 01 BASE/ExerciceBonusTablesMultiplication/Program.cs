//// affichage en tableau
//for (int i = 1; i <= 10; i++)
//{
//    Console.Write($"\t{i,3}");
//}
//Console.WriteLine();
//Console.WriteLine("----------------------------------------------------------------------------------");
//for (int i = 1; i <= 10; i++)
//{
//    for (int j = 1; j <= 10; j++)
//        Console.Write($"\t{i * j}");
//    Console.WriteLine();
//}

//Console.WriteLine("\n\n");



//// Affichage en tableau dynamique

int largeurTables = 10;
const int largeurCol = 3;

Console.WriteLine("Combien de tables ?");
int nbTables = Convert.ToInt32(Console.ReadLine());


//for (int i = 1; i <= largeurTables; i++)
//{
//    Console.Write($"{i,largeurCol}");
//}
//Console.WriteLine();


string sousBarre = string.Concat(Enumerable.Repeat("-", largeurCol));
string barre = string.Concat(Enumerable.Repeat(sousBarre, largeurTables));

//Console.WriteLine(barre);


//for (int i = 1; i <= nbTables; i++)
//{
//    for (int j = 1; j <= largeurTables; j++)
//        Console.Write($"{i * j,largeurCol}");
//    Console.WriteLine();
//}

//// Dynamique avec les bares de séparation des colones


sousBarre = string.Concat(Enumerable.Repeat("-", largeurCol));
barre = "+" + string.Concat(Enumerable.Repeat(sousBarre + "+", largeurTables));

//Console.WriteLine(barre);

//Console.Write("|");
//for (int i = 1; i <= largeurTables; i++)
//{
//    Console.Write($"{i,largeurCol}|");
//}
//Console.WriteLine();

//Console.WriteLine(barre);

//for (int i = 1; i <= nbTables; i++)
//{
//    Console.Write("|");
//    for (int j = 1; j <= largeurTables; j++)
//        Console.Write($"{i * j,largeurCol}|");
//    Console.WriteLine();
//    Console.WriteLine(barre);
//}


// En arc en ciel

List<ConsoleColor> colors = new List<ConsoleColor>()
{
    ConsoleColor.Red,
    ConsoleColor.Magenta,
    ConsoleColor.Blue,
    ConsoleColor.Cyan,
    ConsoleColor.Green,
    ConsoleColor.Yellow
};

sousBarre = string.Concat(Enumerable.Repeat("-", largeurCol));
barre = "+" + string.Concat(Enumerable.Repeat(sousBarre + "+", largeurTables));

Console.ForegroundColor = ConsoleColor.White;
Console.WriteLine(barre);

for (int i = 1; i <= nbTables; i++)
{
    Console.ForegroundColor = colors[i % colors.Count];
    Console.Write("|");
    for (int j = 1; j <= largeurTables; j++)
    {
        Console.ForegroundColor = colors[(i + j) % colors.Count];
        Console.Write($"{i * j,largeurCol}|");
    }
    Console.WriteLine();
    Console.ForegroundColor = ConsoleColor.White;
    Console.WriteLine(barre);
}
