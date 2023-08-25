//List<int> maListe = new List<int>();
//int userInput;
//do
//{
//    for (int i = 0; i <= 10; i++)
//        Console.WriteLine("Insertion des valeurs du tableau :");
//    Console.Write($"Saisir la valeur "+ i);
//    userInput = int.Parse(Console.ReadLine());
//        bool saisieValid;
//    do
//    {
//        saisieValid = (!int.TryParse(Console.ReadLine(), out userInput) &&
//        (userInput < 0));
//        if (!saisieValid)
//        {
//            Console.ForegroundColor = ConsoleColor.Red;
//            Console.WriteLine("Erreur de saisie, veuillez réessayer !");
//            Console.ResetColor();
//        }

//    } while (!saisieValid);

//    maListe.Add(userInput);

//} while (userInput != 0);

using System.Security.Cryptography.X509Certificates;

Console.WriteLine("Insertion des valeurs du tableau :");
List<int> maListe = new List<int>();
for (int i = 0; i < 10; i++)
{
    Console.Write($"Saisir la valeur {i + 1} : ");
    int userInput = int.Parse(Console.ReadLine());
    maListe.Add(userInput);
}
Console.WriteLine(" Affichage des valeurs du tableau :");
string affichage = "";
for (int i = 0; i < maListe.Count; i++)
{
    //affichage = "\t";
    Console.Write(maListe[i] + "\n");
    affichage += "\t";
    Console.Write(affichage);
}