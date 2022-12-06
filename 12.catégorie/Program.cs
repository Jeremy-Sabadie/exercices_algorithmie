using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12.catégorie
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("notez un age:");//Une entrée est demandée à l'utilisateur.
            string Age = Console.ReadLine();//L'entrée demandée est stockée dans la variable Age entant que string.
            int AgeConvert = int.Parse(Age);//Lstring Age est convertie en int dans AgeConvert.
            if (AgeConvert >= 6 && AgeConvert <= 7)//si supérieur ou égal à 6 et inférieur et égal à 7.
            {
                Console.WriteLine("poussin");// On écrit en console "poussin.
            }
            else if (AgeConvert >= 8 && AgeConvert <= 9)//Si supérieur ou égal à 8 et inférieur à 9.
            {
                Console.WriteLine("Pupille");//On affiche "Pupille"
            }
            else if (AgeConvert >= 10 && AgeConvert <= 11)
            {
                Console.WriteLine("Minime");
            }
            else if (AgeConvert >= 12)//Si supérieur ou égal à 12.
            {
                Console.WriteLine("Cadet");//On affiche "Cadet."
            }
            Console.ReadLine();//ligne afin que la console ne se ferme pas aprés l'exécution.
        }

    }
}

