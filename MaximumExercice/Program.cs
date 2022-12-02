using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaximumExercice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Indiquez un premier nombre à comparer");//Un premier entier est demandé en entrée
            int Nb_1 = int.Parse(Console.ReadLine());//La première entrée est attendue.
            Console.Write("Indiquez un deuxième nombre à comparer");//Un deuxième entier est demandé en entrée
            int Nb_2 = int.Parse(Console.ReadLine());//La deuxième entrée est attendue.
            if (Nb_1 > Nb_2)//
            {
                Console.WriteLine(Nb_1 + "est plus grand que " + Nb_2);//Le résultat de la comparison est affichée avec la première possibilité.
            }
            else//L'autre possibilité de résultat de la comparaison.
            {
                Console.WriteLine(Nb_2 + " est supérieur à " + Nb_1);//Le résultat de la comparison est affichée avec la deuxième possibilité.
            }
            Console.ReadLine();//ligne pour ne pas que la console se ferme à la fin du programe.
            
        }
    }
}
