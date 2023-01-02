using System.Globalization;
using System.Security.Cryptography.X509Certificates;
Random random = new Random();
//déclaration  du tableau de Nb entiers.
int Nb = 5;
int[] Tableau = new int[Nb];
//Remplissage du tableau.
for (int i = 1; i < Tableau.Length; i++){
    int NewValue = random.Next(200);
    Tableau[i] = NewValue;
}
//Affichage du tableau avant le tri.
Console.WriteLine("avant le tri: ");
for (int i = 0; i < Tableau.Length; i++)
{
    Console.Write(Tableau[i]+"|");
}
//Triage du tableau:
for (int i = 1; i < Tableau.Length; i++)
{
    int x = Tableau[i];
    int j = i;
    while (j > 0 && Tableau[j - 1] > x)
    {
        Tableau[j] = Tableau[j - 1];
        j--;
        Tableau[j] = x;
        
    } }
//Affichage du tableau aprés le tri.
Console.WriteLine("");
    Console.WriteLine("tableau aprés le tri: ");
    for (int a = 0; a < Tableau.Length; a++)
    {
        Console.Write(Tableau[a] + "|");
    }


    


