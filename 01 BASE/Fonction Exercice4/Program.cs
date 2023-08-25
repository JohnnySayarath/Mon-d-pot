
int compterLettreA(string chaines)
{
    int count = 0;
    foreach (char c in chaines.ToLower())
    {
        if (c == 'a')
            count++;
    }
    return count;
}

Console.WriteLine(compterLettreA("Je m'appelle Johnny Sayarath"));