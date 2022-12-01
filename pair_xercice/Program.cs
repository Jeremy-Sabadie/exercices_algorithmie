using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pair_xercice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Donnez un nombre à vérifier. ");
            string Ask = Console.ReadLine();//Un nombre est demandé en entrée. 
            int Nb = int.Parse(Ask);//L'entrée de l'utilisateur est convertie en entier.
            if (Nb % 2 == 0) //On regarde si le modulo du nombre edivisé par deux est égal à zéro, alors le nombre est 
            {
                Console.WriteLine(Nb+" est un nombre pair"); //On indique que le nombre doné est pair.
            }
            else //sinon si le modu lo de la division par deux n'est pas égal à zéro. 
            {
                Console.WriteLine(Nb+" est un nombre impair"); //On indique que le nombre doné est impair.
            }
            Console.ReadLine();

        }
    }
}
