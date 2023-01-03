int[] Array1 = { 4, 8, 7, 12 };
int[] Array2 = { 3, 6 };
int Sum_T1 = SumArray(Array1);
int Sum_T2 = SumArray(Array2);

int Stroumf = Sum_T1 * Sum_T2;
int SumArray(int[] Tab)
{
    {
        int Total = 0;
        for (int i = 0; i < Tab.Length; i++)
        {
            Total = Total + Tab[i];
        }
        return Total;
    }
    


}
Console.WriteLine($"La valeur du Stroumpf est de: {Stroumf}.");
