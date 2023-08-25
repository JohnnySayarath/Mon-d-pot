for (int nombre = 1; nombre <= 10; nombre++)
{
    Console.WriteLine("Table de " + nombre);
    for (int multiplicateur = 1; multiplicateur <= 10; multiplicateur++)
        Console.WriteLine($"\t {nombre} x {multiplicateur} = {nombre*multiplicateur}");
}