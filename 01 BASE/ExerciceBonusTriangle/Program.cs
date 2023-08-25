Console.WriteLine("Saisir la hauteur du triangle : ");
int hauteur = Convert.ToInt32(Console.ReadLine());


// 1 - avec incrementation et decrementation
int nbEspaces = hauteur - 1;
int nbEtoiles = 1;

for (int ligne = 1; ligne <= hauteur; ligne++)
{
    string espaces = string.Concat(Enumerable.Repeat(" ", nbEspaces)); // sert à répèter des string en c#
    string etoiles = string.Concat(Enumerable.Repeat("*", nbEtoiles));
    Console.WriteLine(espaces + etoiles);
    nbEspaces--;
    nbEtoiles += 2;
}

// 2 - avec calcul du nombre de caractères
for (int ligne = 1; ligne <= hauteur; ligne++)
{
    string espaces = string.Concat(Enumerable.Repeat(" ", hauteur - ligne));
    string etoiles = string.Concat(Enumerable.Repeat("*", 2 * ligne - 1));
    Console.WriteLine(espaces + etoiles);
}

// 3 - avec des boucles imbriquées et Write()
for (int ligne = 1; ligne <= hauteur; ligne++)
{
    for (int espaces = 1; espaces <= hauteur - ligne; espaces++)
        Console.Write(" ");
    for (int etoiles = 1; etoiles <= 2 * ligne - 1; etoiles++)
        Console.Write("*");
    Console.WriteLine();
}