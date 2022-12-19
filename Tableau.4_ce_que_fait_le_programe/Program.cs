
int[] entiers = new int[7];
entiers[0] = 1;

for (int i = 1; i < entiers.Length; i++)//Oncommence à l'index 1 pour pouvoir lui soustraire 1 sans être hors des limites du tableau.
{
    entiers[i] = entiers[i - 1] + 2;//On soustrait 1 à l'index.
}
for (int i = 0; i < entiers.Length; i++)
{
    Console.WriteLine(entiers[i]);
}
//Dans ce programme on change les valeurdes items en leurs soustraiant un.
//