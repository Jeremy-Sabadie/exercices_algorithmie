Console.Write("Notez le nombre de valeurs à stocker:");
int NbValeur = int.Parse(Console.ReadLine());
int[] Array = new int[NbValeur];

int PositiveCount = 0;
int NegativeCount = 0;
for (int i = 0; i < NbValeur; i++)
{
    Console.Write($"Donnez la valeur n°: {i+1} à ranger dans le tableau.");
    Array[i] = int.Parse(Console.ReadLine());
    if (Array[i] < 0)
    {
        NegativeCount++;
    }
    else if (Array[i] >= 0)
    {
        PositiveCount++;
    }
}
Console.WriteLine($"Il y a: {PositiveCount}valeurs positives et {NegativeCount} valeurs négatives");
