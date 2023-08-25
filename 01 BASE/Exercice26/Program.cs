Console.WriteLine("--- Accroissement de la population de Tourcoing ---\n\n");
int year0 = 2015;
double pop = 96806;
double tx = 0.0089;
int popMax = 120000;
int year = year0;

while (pop < popMax)
{
    pop = Math.Round(pop + (pop * tx)); 
    year++;
}

Console.WriteLine($"Il faudra {year - year0} ans, nous serons en {year}");
Console.WriteLine($"Il y aura {pop} habitants en {year}");
