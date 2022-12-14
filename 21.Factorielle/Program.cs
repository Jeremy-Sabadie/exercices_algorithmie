
//Factorielle de N noté n!:
Console.Write("Indiquez un nombre de référence:");
int n = int.Parse(Console.ReadLine());
int It = 1;
int Fact = 1;
while (It <= n)
{
    Fact = Fact * It;
    It++;
}
Console.WriteLine("la factorielle de: " + n + " est égal à : " + Fact);//On affiche le résultat.
//Console.WriteLine($"le produit des entiers de: {n} est égal à : {Fact}");//On affiche le résultat avec une autre méthode de concaténation.
//corection:
int Mois;
do
{
    Mois=int.Parse(Console.ReadLine());
    if (Mois < 1 || Mois > 12)
    {
        Console.WriteLine("erreur, saisir un nombre compris entre 1 et 12");
    }
}while(Mois < 1||Mois>12);