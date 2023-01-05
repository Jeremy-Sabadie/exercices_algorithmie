//Tableau d'entiers classé.
int[] Tab = { 38, 45, 64, 75, 84, 87 };
//Variable contenant la valeur recherchée.
int ValeurCherchee = 38;
//Variable contenant la valeur du premier index du tableau.
int Start = 0;
//Variable contenant la valeur du derniernier index du tableau.
int End = Tab.Length-1;
//Variable correspondant à l'index au molieu du tableau récupérée grace à la fonction IddleArray.
int middle = MiddleArray(Start, End);
//Tant que La valeur de l'index du milieu du tableau est différente du nombre recherché:
while (Tab[middle] != ValeurCherchee)
{//Si la valeur de l'index du milieu du tableau estsupérieure à la valeur recherchée
    if (ValeurCherchee > Tab[middle])
    {//Le milieu du tableau devient son début pour exclure de a recherche la zone du tableau qui ne contient pas la valeur recherchée.
        Start = middle;
    }//Sinon le milieu du tableau devient sa fin pour exclure le début du tableau qui ne contient pas la valeur recherchée.
    else
    {
        End = middle;
    }
    middle = MiddleArray(Start, End);
}
Console.WriteLine($"l'élément recherché se situ à l'index {middle}");









//fonction MiddleArray pour trouver le milieu d'un tableau :
int MiddleArray(int debut, int fin)
{
    int Mid = (debut + fin) / 2;
    return Mid;
}