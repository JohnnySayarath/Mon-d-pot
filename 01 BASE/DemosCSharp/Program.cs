for (int i = 0; i < 20; i++)
{
    if (i == 7 || i == 14)
        continue;

    if (i == 18)
        break;

    Console.WriteLine(i);
}

Console.WriteLine("Fin boucle");