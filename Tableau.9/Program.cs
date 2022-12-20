using System;

int[] Tableau = { 12, 15, 33, 46, 50, 1, 8, 10 };//Déclaration du tableau.
int Tmp = 0;

AfficherTableau(Tableau);

for (int j = 0; j < Tableau.Length-1; j++)//Boucle for qui englobe la deuxième boucle for.
{
    for (int i = 0; i < Tableau.Length - 1-j; i++)//boucle for qui parcourt les items du tableau "Array" sauf celui rangé au tour d'avant"j".
    {
        if (Tableau[i] > Tableau[i + 1])//Si la valeur stockée dans l'index parcouru est supérieure à la valeur correspondante à l'index suivant, on intervertit les deux valeurs.
        {
            //Permutation des deux variables à l'aide de la variable Tmp
            Tmp = Tableau[i + 1];//On sauvegarde la valeur de l'item parcourru dans la variable temporaire.
            Tableau[i + 1] = Tableau[i];//La valeur de l'tem suivant(plus grande  est remplacé par la valeur de l'item parcouru(plus petit).
            Tableau[i] = Tmp;//La valeur de l'item parcourru est remplacé par la variable temporaire(donc la valeur plus grande).Fin de la permutation des deux variables.
        }//Fin de la boucle for englobante. 

    } 
}

AfficherTableau(Tableau);

void AfficherTableau(int[] Tableau)
{
    Console.Write("[ ");
    for (int i = 0; i < Tableau.Length; i++)
    {
        if (i != Tableau.Length - 1)
        {
            Console.Write($"{Tableau[i]},");
        }
        else
        {
            Console.Write($"{Tableau[i]}");
        }
    }
    Console.WriteLine("]");
}






