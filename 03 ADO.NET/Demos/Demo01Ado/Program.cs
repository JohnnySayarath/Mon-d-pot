using Microsoft.Data.SqlClient;
using System.Data;

// Communiquer avec une base de données
string connectionString = "Data Source=(localdb)\\AdoNet;Integrated Security=True";

// C
SqlConnection connection = new SqlConnection(connectionString); // Connexion à la connectionString
connection.Open(); // Connexion au serveur

if (connection.State == ConnectionState.Open)
    Console.WriteLine("Connexion OK");
else
    Console.WriteLine("Connexion erreur");


void Method1()
{
    //Execution de requêtes

    //Requête en dur
    //string request = "INSERT INTO personne (nom, prenom, telephone) VALUES ('toto', 'tata', '0101010101')";

    //Requête avec paramètres
    string nom = "toto";
    string prenom = "tata";
    string telephone = "0101010101";
    string request = $"INSERT INTO personne (nom, prenom, telephone) VALUES (@nom, @prenom, @telephone)";  // Premier exemple

    // Objet commande
    SqlCommand command = new SqlCommand(request, connection);

    //Ajout de paramètres 
    command.Parameters.Add(new SqlParameter("@telephone", "06%"));
    command.Parameters.Add(new SqlParameter("@prenom", prenom));
    command.Parameters.Add(new SqlParameter("@telephone", telephone));


    // Execution des commandes
    // 1e ExecuteNonQuery =>  nombre d'entrées ajoutées/modifié/supprimées retourné par la base de données
    // Il n'est pas fait pour des requêtes SELECT

    int nbLignesModifiees = command.ExecuteNonQuery();
    Console.WriteLine($"{nbLignesModifiees} ont été ajoutées");



    //ATTENTION IL FAUT TOUJOURS FERMER LA CONNEXION

    //Libération de la ressource command
    command.Dispose(); // Dispose = permet de se débarasser de quelques chose en C#

    //Fermeture de la connexion 
    connection.Close();
};

void Methode2Select()
{
    //Execution de requêtes
    string request = $"SELECT nom, prenom, telephone FROM personne WHERE telephone LIKE @search";

    // Objet commande
    SqlCommand command = new SqlCommand(request, connection);

    //Ajout de paramètres 
    command.Parameters.Add(new SqlParameter("@telephone", "06%"));

    // Execution des commandes



    //ATTENTION IL FAUT TOUJOURS FERMER LA CONNEXION

    //Libération de la ressource command
    command.Dispose(); // Dispose = permet de se débarasser de quelques chose en C#

    //Fermeture de la connexion 
    connection.Close();
};

void Method3Reader()
{
    //Execution de requêtes
    string request = $"SELECT nom, prenom, telephone FROM personne WHERE telephone LIKE @search";

    // Objet commande
    SqlCommand command = new SqlCommand(request, connection);

    //Ajout de paramètres 
    command.Parameters.Add(new SqlParameter("@telephone", "06%"));

    // Execution des commandes
    // 1e ExecuteReader =>  permet de récupérer un objet pour lire les données retournées par la base de données
    SqlDataReader reader = command.ExecuteReader();

    while (reader.Read()) // permet de passer de ligne/entrée en ligne => renvoie false si plus de ligne à lire
    {
        Console.WriteLine($"Nom : {reader.GetString(1)}, Prenom : {reader.GetString(2)}, Telephone : {reader.GetString(3)}");
    }

    //ATTENTION IL FAUT TOUJOURS FERMER LA CONNEXION

    //Libération de la ressource command
    command.Dispose(); // Dispose = permet de se débarasser de quelques chose en C#

    //Fermeture de la connexion 
    connection.Close();
};

// Mot clé using 
// losque l'on quitte le bloc, la méthode .Dispose est toujours appelée
using (SqlConnection connection2 = new SqlConnection(connectionString))
{
    connection2.Open();
    using (SqlCommand cmd = new SqlCommand("<request>", connection2))
    {
        // Parameters, ExecuteReader, ...
    } // => cmd.Dispose()
}// connection2.Dispose() => appelle .Close() au passage
