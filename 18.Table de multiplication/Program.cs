using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18.Table_de_multiplication
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("donnez un nombre:");
            int Nb = int.Parse(Console.ReadLine());
            int Mult = 1;
            int Result = 1;
            while (Mult <= 10)
            {
                Result = Nb * Mult;
                Console.WriteLine($"     {Nb} X {Mult} est égal a: {Result}");
                Mult++;
            }
            Console.ReadLine();




        }
    }
}
