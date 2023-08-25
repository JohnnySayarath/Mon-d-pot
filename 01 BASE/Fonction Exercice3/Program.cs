//int Add10(int numero = 12)
//{
//    return numero + 12;
//}

//Console.WriteLine(Add10());
//Console.WriteLine(Add10(125));
//Console.WriteLine(Add10());
//Console.WriteLine(Add10(1));


void QuelleHeure(string heure = "12", string minute = "00")
{

    Console.WriteLine($"Il est {heure}H{minute}");
    
}
QuelleHeure();
QuelleHeure("14", "00");
