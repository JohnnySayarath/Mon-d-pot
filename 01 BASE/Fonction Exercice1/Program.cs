string NomComplet(string prenom, string nom)
{
    string espace = " ";
    return ($"{prenom}{espace}{nom}");
}

Console.WriteLine(NomComplet("John", "Doe"));