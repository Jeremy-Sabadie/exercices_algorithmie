
using System.Net.Security;

int[] entiers = new int[10];//Tbleau pouvant contenir 10 entier
entiers[0] = 1;//Le premer item du tableau est égal à 1.
entiers[1] = 1; //Le premer item du tableau est aussi égal à 1.

for (int i = 2; i < entiers.Length; i++)//Boucle qui parcours le tableau entiers du  deuxième item jusqu'au dernier.
{
    entiers[i] = entiers[i - 1] + entiers[i - 2];//à chaque tour de boucle, on y stocke la somme des deux cases d'avant. 
}

for (int i = 0; i < entiers.Length; i++)//le tableau est re parcourru de l'ndex 0 jusqu'au dernier index.
{
    Console.WriteLine(entiers[i]);// L'index en cour dans la boucle est affiché dans la console.
}