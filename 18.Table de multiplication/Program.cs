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
            Console.Write("Vous voulez afficher la table de?:");
            int Nb = int.Parse(Console.ReadLine());
            int Mult = 1;
            int Result = 1;
            while (Mult <= 10)
            {
                Result = Nb * Mult;
                Console.WriteLine($"     |_{Nb}|_X_|{Mult}_|___est_égal_a:___|{Result}|");
                Mult++;
            }
            Console.ReadLine();




        }
    }
}
