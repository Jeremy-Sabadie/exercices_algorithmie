using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercice_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("donner un rayon en Cm.");//On  demande une valeur de rayon à l'utilisateur.
            string CircleRayon = Console.ReadLine();//On stocke la valeur de L'entrée utilisateur dans la variable CircleRayon.
            int R = int.Parse(CircleRayon);// la variable CicleRayon est convertie en entier et stockée dans la variable R.

            double Perimeter = 2 * Math.PI * R;
            Console.WriteLine(" un cercle avec un rayon de " + CircleRayon + " a un périmètre de: " + Perimeter + " Cm.");// on affiche le résultat du calcul du périmètre ddans la console.
            Console.ReadLine();
        }
    }
}
