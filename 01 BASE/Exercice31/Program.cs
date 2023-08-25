//définir min max sum nbnotes
float max = 0, min = 20, somme = 0, moyenne;
int nbNotes = 1;
int userInput;

while (true)
{
    string choice;
    Console.WriteLine("--- Gestion des notes avec menu ---\n ");
    Console.Write("1----Saisir les notes" +
        "\n2----La meilleure note" +
        "\n3----La pire note" +
        "\n4----La moyenne des notes" +
        "\n0----Quitter" +
        "\n\nFaites votre choix : ");
    choice = Console.ReadLine();
    Console.Clear();

    switch (choice)
    {
        case "1":
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("----- Saisir les notes -----" +
                "\n(999 pour stoper la sasie)\n");
            Console.ForegroundColor = ConsoleColor.Gray;
            do
            {
                bool saisieValide;
                do
                {
                    Console.Write("- Merci de saisir la note " + nbNotes + "(sur /20) :");
                    saisieValide = int.TryParse(Console.ReadLine(), out userInput) // notre saisie est un entier
                                && (                                            // ET
                                    userInput == 999                            // notre valeur est égale à 999
                                    ||                                          // OU
                                    (userInput >= 0 && userInput <= 20)         // notre valeur est comprise entre 0 et 20
                                    );
                    //saisieValide = int.TryParse(Console.ReadLine(), out userInput)&& (userInput == 999 || (userInput >= 0 && userInput <= 20));
                    if (!saisieValide)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("\tErreur de saisie, la note est sur 20 !");
                        Console.ResetColor();
                    }
                } while (!saisieValide);

                //if (userInput == 999)
                //    break;

                if (userInput != 999)
                {
                    if (userInput > max)
                        max = userInput;
                    if (userInput < min)
                        min = userInput;
                    somme += userInput;
                    nbNotes++;
                }
            } while (userInput != 999);


           
            break;
        case "2":
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("----- La plus grande note -----\n");
            Console.WriteLine("\nla meilleure note est " + max + "/20");
            Console.ForegroundColor = ConsoleColor.Gray;
            break;
        case "3":
            
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("----- La plus petite note -----");
            Console.WriteLine("la moins bonne note est " + min + "/20");
            Console.ForegroundColor = ConsoleColor.Gray;
            break;
        case "4":
            moyenne = somme / ((float)nbNotes - 1);
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("----- La moyenne des notes -----");
            Console.WriteLine("la moyenne des note est " + moyenne + "/20");
            Console.ForegroundColor = ConsoleColor.Gray;
            break;
        case "0":
            Environment.Exit(0);  // sortir du programme
            break;
        default:
            Console.WriteLine("Erreur de saisie, recommencez !");
            break;
    }
}