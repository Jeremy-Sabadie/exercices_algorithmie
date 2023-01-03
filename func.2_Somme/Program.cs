int Nb1 = 8;
int Nb2 = 5;

int Somme = Sum(Nb1, Nb2);
Console.WriteLine($"Le résultat de {Nb1} plus {Nb2} est égal à: {Somme}");

int Sum(int Nombre1, int Nombre2)
{
    int Total = Nombre1 + Nombre2;
    return Total;
}