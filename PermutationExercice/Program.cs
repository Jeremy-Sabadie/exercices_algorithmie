using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PermutationExercice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int c1 = 3;//On déclare la variable c1 avec une valeur de 3.
            Console.WriteLine("la variable c1 est égaleà: " + c1);
            int c2 = 5;//La variable c2 est déclarée avec 5 comme valeur.
            Console.WriteLine("la variable c2 est égaleà: " + c2);
            int temp = 1;//La variable temporaire temp est créee pour la permutation des deux autres variables.
            temp = c1;// La valeur de c1 est stockée dans la variable temporaire temp.
            c1 = c2;//La valeur de la variable c2 est affectée à c1
            c2 = temp;//La valeur de c1 stockée dan temp est donnée à c2
            Console.WriteLine("apré la permutation la variable c1 est égale à: "+c1);//La  valeur de c1 apré la permutation est affichée. 
            Console.WriteLine("apré la permutation la variable c2 est égale à: " + c2);//La  valeur de c2 apré la permutation est affichée.
            Console.ReadLine();
        }
    }
}
