Console.WriteLine("--- Les suites chaînées de nombres ---\n");
Console.Write("Merce de saisir un nombre : ");
int number = int.Parse(Console.ReadLine());


Console.WriteLine("Les chaînes possibles sont :");

int midNumber = number / 2 + 1;
// il est inutile de vérifier si de suite chainées commencent au dela de ce nombre
// dans le cas d'un nombre impair la dernière suite chainée correspond toujours aux entier englobant la moitiée
// ex : 45/2=22.5   =>   45=22+23

for (int i = 1; i <= midNumber; i++)
{
    int sum = 0;
    bool validChain = false;
    int maxChain = 0;

    for (int j = i; j <= midNumber; j++)
    //for (int j = i; sum < number; j++)
    {
        sum += j;
        if(sum == number)
        {
            validChain = true;
            maxChain = j;
            // possible d'optimiser en s'arrêtant ici avec break
        }
    }

    if (validChain)
    {
        Console.Write($"{number} = {i}");
        for (int j = i+1; j <= maxChain; j++)
        {
            Console.Write("+" + j);
        }
        Console.WriteLine();
    }
}