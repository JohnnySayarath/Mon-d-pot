
//string espace;
//for (int i = 0; i <= lettre.Count; i++)
//{
//    espace = "  ";
//    Console.Write(lettre[i]);
//    espace += "  ";
//    Console.Write(espace);
//}

string espace = "";
char c = Convert.ToChar(65);
for (int i = 0; i < 26; ++i)
{
    Console.WriteLine(c);
    c++;
    espace += "  ";
    Console.Write(espace);
}