//somme des cinq premier entiers pairs:
int n = 500;
int Sum = 0;// La variable somme est initiée avec la valeur 0 pour commencer.

int It = 0;//Le premier nombre à additionner à la somme est 0.



while (It <= n*2)//Tant que le nombre multipilé est inférieur au nombre de référence.
{
    if (It % 2 == 0)//On vérifie que le nombre testé est pair.
    { //On dit que si le nombre testé est pair et inférieur au nombre de référence, on l'ajoutera à la somme.
        Sum = Sum + It;//Dans le cas oùIt est pair,on l'ajoute à la somme'
    }
    It++;
}
Console.WriteLine("la somme des 5 premiers entiers pairs est égal à: " + Sum + " . ");//On affiche le résultat
Console.WriteLine("Et c'est faut!");//On affiche le résultat
