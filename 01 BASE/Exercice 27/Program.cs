Console.WriteLine("--- Les suites chaînées de nombres ---\n");
Console.Write("Merce de saisir un nombre : ");
int number = int.Parse(Console.ReadLine());


Console.WriteLine("Les chaînes possibles sont :");

int midNumber = number / 2 + 1;
// il est inutile de vérifier si de suite chainées commencent au dela de ce nombre
// dans le cas d'un nombre impair la dernière suite chainée correspond toujours aux entier englobant la moitiée
// ex : 45/2=22.5   =>   45=22+23
int debutChaine = 1;
while (debutChaine <= midNumber)
{
    int sum = 0;
    bool validChain = false;
    int finChaine = 0;

    int nombreAdditionner = 1;
    while ( nombreAdditionner <= midNumber)
    {
        sum += nombreAdditionner;
        if (sum == number)
        {
            validChain = true;
            finChaine = nombreAdditionner;
            break;
        }
        nombreAdditionner++;
    }

    if (validChain)
    {
        Console.Write($"{number} = {debutChaine}");
        for (int j = debutChaine + 1; j <= finChaine; j++)
        {
            Console.Write("+" + j);
        }
        Console.WriteLine();
    }
    debutChaine++;
}