using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_signe_dun_produit
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("indiquez un premier nombre différent de zéro :");//Un premier nombre est demandé.
           int Nb1= int.Parse(Console.ReadLine());//Un premier nombre est attendu.
            Console.Write("indiquez un deuxième nombre différent de zéro :");//Un deuxième nombre est demandé.
            int Nb2 = int.Parse(Console.ReadLine());//Un deuxième nombre est attendu.

            if ((Nb1 > 0 && Nb2 > 0)|| (Nb1 < 0 & Nb2 < 0))//Si (Nb1supérieur à zéro et Nb1 supérieur à zéro et Nb2 supérieur à zéro) ou (Nb1 inférieur à zéro et Nb2 inférieur à zéro)
            {
                Console.WriteLine("le produit des deux nombre est positif.");//On indique que la somme des deux variable est positive.
            
            }
            else//sinon s i la con dition n'est pas remplie.
            {
                Console.WriteLine("le produit des deux nombre est négatif.");//On indique que la somme des deux variable est négative.
                Console.WriteLine($"{Nb1} x{ Nb2}");//autre façon de cocaténer.
            }
            Console.ReadLine();
            
        }
    }
}
