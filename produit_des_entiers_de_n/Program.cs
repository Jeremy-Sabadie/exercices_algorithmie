
//Factorielle de 3sécrit:!3et cest égal à 6.
//Factorielle de N
int N = 5;//Nombre de référence à ateindre.
int It = 1;//itérateur qui va être multiplié à la somme à chaque tours.
int Sum = 1;//La variable somme est initiée à 1 pour commencer.
while (It <= N)//Tant que la somme du produit des entiers pécédents le chiffre servant de référence.
{
    Sum = Sum * It;//La  somme est multipliée par la valeur de l'itérateur.
    It++;//La valeur de l'itérateur augmente de un à chaque tour jusqu'a ateindre la valeur du nombre de référence.
}
Console.WriteLine("le produit des entiers de: " + N + " est égal à : " + Sum);