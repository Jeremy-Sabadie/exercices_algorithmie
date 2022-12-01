using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NoteExercice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Indiquez la note.");//On demande un nombre à l'utilisateur.
            string NoteExercice = Console.ReadLine();//On attend l'entrée de l'utilisateur.
            int NoteConvert = int.Parse(NoteExercice);// Lentrée est converti en entier.
            if (NoteConvert >= 10)//La variable est comparée à dix.
            {
                Console.WriteLine("Admis");//Dans le cas où elle est supérieure à dix  on affiche admis.
            }
            else if (NoteConvert > 8)//Sinon si elle est supérieur à la valeur huit. 
            {
                Console.WriteLine("Ratrapage");//On affiche ratrapage.
            }
            else if (NoteConvert < 8)//On vérifie une l'autre possibilité où elle serait inférieure à huit.
            {
                Console.WriteLine("Echec");//Dans ce cas on affiche Echec.
            }

        }
    }
}
