int[] Array_1 = { '4', '8', '7', '9', '1', '5', '4', '6' };
int SumArray_1 = 0;
int[] Array_2 = { '7', '6', '5', '2', '1', '3', '7', '4' };
int SumArray_2 = 0;

for (int i = 0; i < Array_1.Length; i++)
{
SumArray_1=SumArray_1+ Array_1[i];
    SumArray_2 = SumArray_2 + Array_2[i];
}
int TotalSum = SumArray_1 + SumArray_2;

Console.WriteLine($"la somme de deux tableaux est égale à : {TotalSum}");