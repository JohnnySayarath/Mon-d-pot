//string chaine = SaisieAdn("Veuillez saisir une chaine adn :");
//string sequence = SaisieAdn("Veuillez saisir une sequence adn :");
//Console.WriteLine("chaine : " + chaine);
//Console.WriteLine("sequence : " + sequence);
//double pct = Proportion(chaine, sequence);
//Console.WriteLine($"Il y a {Math.Round(pct, 2)}% de \"{sequence}\" dans la chaine \"{chaine}\"");

    Console.WriteLine("Veuillez saisir une chaine adn");
    string saisieInput = Console.ReadLine().ToLower();
string SaisieAdn(string saisieInput)
{
    bool saisieValid = false;
    if (!(saisieInput == "a" || saisieInput == "c" || saisieInput == "g" || saisieInput == "t" ))
        Console.WriteLine("Erreur de saisie !!!");
    return saisieInput;
}