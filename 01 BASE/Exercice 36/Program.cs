Console.WriteLine("***** Tableaux des notes *****");
Console.Write("Combiens de notes comportera le tableaux : ");
int nombreDeNotes;

while (!int.TryParse(Console.ReadLine(), out nombreDeNotes))
{
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine("\tErreur de saisir, merci de saisir un chiffre/nombre\n");
    Console.ResetColor();
    Console.Write("Merci de saisir combiens de notes comportera le tableau : ");
}

List<double> notes = new List<double>();

Console.WriteLine($"\nMerci de saisir les {nombreDeNotes} notes\n");

for (int i = 0; i <= nombreDeNotes; i++)
{
    Console.Write($"La note {i+1} est de : ");
    double note;
    while (!(double.TryParse(Console.ReadLine(), out note) && note >= 0 && note <= 20))
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine($"\tErreur, merci de saisir un chiffre/nombre pour la note {i} : ");
        Console.ResetColor();
        Console.Write($"Merci de saisir la note {i} : ");
    }
    notes.Add(note);
}
Console.ForegroundColor = ConsoleColor.DarkYellow;
Console.WriteLine("--- Liste des notes ---");
Console.ResetColor();
for (int i = 0; i <= nombreDeNotes; i++)
{ 
foreach (double note in notes)
    Console.WriteLine($"La note {i+1} est : {note}");
}

double noteMax = notes.Max();
double noteMin = notes.Min();
double moyenne = notes.Average();

Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine("--- Note maximale : " + noteMax);
Console.ResetColor();
Console.ForegroundColor = ConsoleColor.Red;
Console.WriteLine("--- Note minimale : " + noteMin);
Console.ResetColor();
Console.ForegroundColor = ConsoleColor.Blue;
Console.WriteLine("--- Moyenne : " + moyenne);
Console.ResetColor();