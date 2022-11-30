using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercice_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("donner un nombre:");
            string Nb = Console.ReadLine();//Ondemande un nombre à l'utilisateur.
            int Nombre = int.Parse(Nb);//On converti l"entréée de l'utilisateur en entier pour pouvoir l'élever au cube.
            Console.WriteLine("votre nmbre est: " + Nombre);
            int Cube = Nombre * Nombre * Nombre;// stocke le cube du nombre donné
            Console.WriteLine(Nombre+" élevé au cube est égal à : "+Cube+" .");// On affiche la valeur de la variable Cube.
            Console.ReadLine();// Cette ligne sert seulement à ce que la console ne se ferme pas à la fin de l'exécution du débogage.

            

        }
    }
}
