using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Signe_d_un_nombre
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine
                ("indiquez un nombre");
            string Ask = Console.ReadLine();//Une entrée est demandée à l'utilisateur.
            int Convert = int.Parse(Ask);//L'entrée en string est convertie en entier 
            if (Convert > 0)//On vérifie si la variable est supérieure à zéro.
            {
                Console.WriteLine("nombre positif");//Si la variable est supérieure à zéro, le nombre est positif

            }
            else { Console.WriteLine("nombre négatif!"); }//Sinon si  elle n'est pa supérieure à zéro, la valeur de la variable est négative.
            Console.ReadLine();// Lie afin que la console reste ouverte.
        }
    }
}
