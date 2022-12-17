Random objRandom = new Random();

int nbATrouver = objRandom.Next(100);

int count = 0;
//int Proposition = int.Parse(Console.ReadLine());
bool Trouve = false;
while (Trouve == false)
{
    count = count + 1;
    Console.Write("Indiquez un nombre:");
    int Proposition = int.Parse(Console.ReadLine());
    if (Proposition > nbATrouver)
    {
        Console.WriteLine("-");
    }

    else if (Proposition < nbATrouver)
    {
        Console.WriteLine("+");

    }
    else
    {
        Console.WriteLine("Bravo");

        Trouve = true;
    }
}
Console.WriteLine($"Il à fallut {count} coups pour trouver le nombre qui était {nbATrouver}.");