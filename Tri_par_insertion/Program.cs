using System.Globalization;
using System.Security.Cryptography.X509Certificates;

Random random = new Random();
int Nb = 7;
int[] Tableau = new int[Nb];//Déclaration du tableau pouvant contenir jusqu'à 7 items.

for (int i = 0; i < Nb; i++)//Boucle pour parcourir le tableau et y ranger la valeur générée.
{
    int NewValue = random.Next(100);//Un nombre entr 0 et 99 est généré et stocké dans la variable "NewValue".
    Tableau[i] = NewValue;//On range la valeur dans le tableau en l'affectant à lindex actuellement parcouru.
}//On affiche en console l'état du tableau rempli avant de faire le tri.
Console.WriteLine("Tableau avant le tri : ");
for (int i = 0; i < Tableau.Length; i++)
{
    Console.Write(Tableau[i] + "|");//Les index sont séparés par | lors de l'affichage.
}


//boucle du deuxième item(on démare au deuxième item pour pouvoir le comparer au premier) on boucle jusqu'au dernier item du tableau.
for (int i = 1; i < Tableau.Length; i++)
{
    //On mémorise la valeur de l'index parcouru dans x.
    int x = Tableau[i];

    // On fait une boucle qui décale les éléments  qui sont plus grands que x à partir de l'item actuellement comparé jusqu'au dernier item du tableau.

    //j ← i
    int j = i;
    //tant que j > 0 et T[j - 1] > x
    while (j > 0 && Tableau[j - 1] > x)
    {
        //L'item actuel est décalé à l'index d'avant.
        Tableau[j] = Tableau[j - 1];
        j--;//Le nombre d'items à parcourir au tour suivant est diminué de un étant donné qu'un item vient d'être rangé lors du tour de boucle précédent.
    }
    Tableau[j] = x;//La valeur de x est placée dans la case du tableau qui est laissée vide aprés le décalage.
}
//On affiche le tableau rangé en console.
Console.WriteLine("Tableau après le tri : ");
for (int i = 0; i < Tableau.Length; i++)
{
    Console.Write(Tableau[i] + "|");
}
//fonction pour afficher le tableau:
//    AfficherTableau(Tableau);

//void AfficherTableau(int[] Tableau)
//{
//    Console.Write("[ ");
//    for (int i = 0; i < Tableau.Length; i++)
//    {
//        if (i != Tableau.Length - 1)
//        {
//            Console.Write($"{Tableau[i]},");
//        }
//        else
//        {
//            Console.Write($"{Tableau[i]}");
//        }
//    }
//    Console.WriteLine("]");
