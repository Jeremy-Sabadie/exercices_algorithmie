int IsPair(int Nb)
{
    bool Pair = false;

    if(Nb % 2 == 0) { Pair= true; }
    if(Pair==true){ Console.WriteLine($"Le nombre: {Nb} est pair."); }
    else if(Pair==false) { Console.WriteLine($"Le nombre: {Nb} est impair."); }
    return Nb;
}
IsPair(43);
IsPair(42);

