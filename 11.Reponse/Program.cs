using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.Reponse
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Inscrivez un charactère:");//On demande un charactère à l'utilisateur.
            char letter = Console.ReadLine()[0];//On récupère l'entrée utilisateur dan la vaiable letter
            //char letter = Console.ReadKey().KeyChar cette instrucyion récupère la valeur du charactère de la touche tapée.
            switch (letter)//On donne comme vérification à vérifier, si la variableest égale à 'o' ou 'O'.
            {
                case 'o':// Dans un premier temp si la condition  'o' est vérifiée:
                    Console.WriteLine("affirmatif");
                    Console.ReadLine();
                    break;
                case 'O':// Dans un premier temp si la condition  'N' est vérifiée:
                    Console.WriteLine("affirmatif");//On affichera en console: affirmatif.
                    Console.ReadLine();
                    break;
                case 'n':// Dans un premier temp si la condition  'n' est vérifiée:
                    Console.WriteLine("négatif");//On écrira en console:négatif
                    Console.ReadLine();
                    break;
                case 'N':// Dans un premier temp si la condition  'N' est vérifiée:
                    Console.WriteLine("négatif");//On écrira en console:négatif.
                    Console.ReadLine();
                    break;
                default:
                    Console.WriteLine("????");
                    break;

                    Console.ReadLine();

            }
        }
    }

}
                    
            

        
    

