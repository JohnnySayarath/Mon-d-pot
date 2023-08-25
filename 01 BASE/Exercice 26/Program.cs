Console.WriteLine("--- Accroissement de population ---\n");
int habMax = 120000;
int anneeDepart = 2015;
int annee = 0;
double tx = 0.0089;
int hab = 96809;

while (hab <= habMax)
{
    annee++;
    hab = (int)(hab + (hab * tx));
}
Console.WriteLine($"Il faudra {annee} ans, nous serons en {anneeDepart+annee}");
Console.WriteLine($"Il y aura {hab} habitant en {anneeDepart+annee}");