


//Factorielle de N noté n!:
int n = 5;
int It = 1;
int Fact = 1;
while (It <= n)
{
    Fact = Fact*It;
    It++;
}
Console.WriteLine("le produit des entiers de: "+n+" est égal à : "+ Fact);//On affiche le résultat.
Console.WriteLine($"le produit des entiers de: { n} est égal à : { Fact}");//On affiche le résultat avec une autre méthode de concaténation.
