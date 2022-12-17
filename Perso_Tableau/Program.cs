int NBnotes = 5//Le nombre de notes est défini dan une variable
int Sum = 0;//Cett variable servia à calculer la somme des notes du tableau pour calculer la moyenne des notes.
int[] Array = new int[NBnotes];

for (int i = 0; i <NBnotes; i++)//Boucle for autant que la valeur de la varia ble du nombre de notes.
{
    Console.WriteLine("Entrez une note ");//On demande une note à l'utilisateur.
    Array[i] = int.Parse(Console.ReadLine());//Lentrée de l'utilisateur est stockée dans le tableau et un numéro d'index lui est attrbué.
    Sum = Sum + Array[i];//La nouvelle note est additionnée à la somme du tableau
}
int Moy = Sum / NBnotes//La somme des notes est divisée par le nombre de notes.
Console.WriteLine($"lamoyenne des notes est de:{Moy}.");//le résultat est affiché en console.