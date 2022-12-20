int[] Array_1 = { 4, 8, 7, 12 };
int[] Array_2 = { 3, 6 };
int Total = 0;
for (int i = 0; i < Array_1.Length; i++)
{
    int Calcul = (Array_1[i] * Array_2[0]) + (Array_1[i] * Array_2[1]);
    Total += Calcul;
}
Console.WriteLine($"Le stroumf des deux tableaux est égal à: {Total}");

