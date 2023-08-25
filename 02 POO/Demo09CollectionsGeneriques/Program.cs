//using System.Collection.Generics; // déjà fait mais caché

//List

List<string> mesChaines = new List<string>()
{
    "chaine1",
    "chaine2",
    "chaine2",
    "chaine3",
    "chaine4",
    "chaine5",
};

foreach (string item in mesChaines)
{
    Console.WriteLine(item);
}
Console.WriteLine("----------------------------");

mesChaines.Remove("chaine2");
mesChaines.RemoveAt(0);
mesChaines.Add("chaine6");

foreach (string item in mesChaines)
{
    Console.WriteLine(item);
}

mesChaines.Clear();

Console.WriteLine("----------------------------");

// Dictionnary

Dictionary<string, int> participationAuCours = new Dictionary<string, int>()
{
    {"Rémy", 25},
    {"Grégory", 26 },
    //{"Grégory", 26 } // la clé est unique (pas de doublon)
};

Console.WriteLine(participationAuCours["Rémy"]);
Console.WriteLine(participationAuCours["Grégory"]);

participationAuCours.Add("Aïcha", 27);
participationAuCours.Add("Slimane", int.MaxValue);

Console.WriteLine(participationAuCours["Aïcha"]);
Console.WriteLine(participationAuCours["Slimane"]);

participationAuCours["Slimane"] = 43;

participationAuCours.Remove("Rémy");

foreach (KeyValuePair<string, int> item in participationAuCours)
{
    Console.WriteLine($"Le participant {item.Key} est intervenu {item.Value} fois.");
}

//Queue

Queue<string> myQ = new Queue<string>();

myQ.Enqueue("Hello");
myQ.Enqueue("World");
myQ.Enqueue("!");

Console.WriteLine(myQ.Count);

Console.WriteLine(myQ.Dequeue());
Console.WriteLine(myQ.Count);
Console.WriteLine(myQ.Dequeue());
Console.WriteLine(myQ.Dequeue());
Console.WriteLine(myQ.Count);