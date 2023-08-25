List<string> contacts = new List<string>();
Console.WriteLine("===== Gestion des Contacts =====");
Console.Write("Merci de saisir le nombre de contact : ");
int numberContact = int.Parse(Console.ReadLine());
Console.Clear();

while (true)
{
    Console.WriteLine("----- Ma liste de contacts -----");
    Console.WriteLine("1) Saisir des contacts");
    Console.WriteLine("2) Afficher mes contacts");
    Console.WriteLine("0) Quitter\n");
    Console.Write("Faites votre choix : ");
    string choice = Console.ReadLine();
    Console.Clear();

    switch (choice)
    {
        case "1":
            do
            {
                string userInput;

                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("----- Saisir les contacts -----");
                Console.ResetColor();
                for (int i = 0; i < numberContact; i++)
                {
                    Console.WriteLine($"Nom et prénom du contact N° {i + 1} : ");
                    userInput = Console.ReadLine();
                    contacts.Add(userInput);
                }
                Console.Clear();
            } while (!true);
            break;

        case "2":
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("----- Affichage des contacts -----");
                Console.ResetColor();
                foreach (string element in contacts)
                {
                    Console.WriteLine($"\t  -Contact : {element}");
                }


            }
            break;

        case "0":
            Environment.Exit(0); // arrête le programme => les instructions après la boucle ne seront jamais exécutées
            break;

        default:
            Console.WriteLine("Erreur de saisie, recommencez !");
            break;
    }
}