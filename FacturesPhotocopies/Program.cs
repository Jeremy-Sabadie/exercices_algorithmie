using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacturesPhotocopies
{
    internal class Program
    //Un magasin de reprographie facture 0,10 E les dix premières photocopies, 0,09 E les vingt suivantes et 0,08 E au-delà.
    //Écrivez un algorithme qui demande à l’utilisateur le nombre de photocopies effectuées et qui affiche la facture correspondante.
    {
        static void Main(string[] args)
        {
            int NbCopy = int.Parse(Console.ReadLine());// 
            Console.Write("Inndiquez le nombre de photocopies");//
            const double FirstPrice = 0.10;//Un prix est demandé pour les dix premières copies
            const double SecondPrice = 0.8;//Un second prix est stocké pour les vingt copies suivantes. 
            double Facture = (NbCopy - 10) *
                SecondPrice + (10 * FirstPrice);
            //Console.WriteLine("le montant de la facture est de : " +);

        }
    }
}
