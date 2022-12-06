
Console.Write("Indiquez le nombre de photocopies: ");
int NbCopies = int.Parse(Console.ReadLine());//Le nombre de copies demandé est récupéré dans une variable de type int.
const float TenFirstPrice = 0.10f;//Le prix des dix premières copies est défini dans une constante type float. 
const float NextCopiesPrice = 0.09f;//Le prix des copies faites apés les dix premières est défini dans une constante type float.
float Facture =0;
if (NbCopies <= 10)//Si  le nombre de copies est supérieur ou égal à dix.
{
    Facture = NbCopies * TenFirstPrice;//Le résultat des dix première copies multipliées par le prix correspondant.
}
else if(NbCopies >= 20&& NbCopies<=30)//Si le nombre de copies est compris entre 20 et 30.
{
    NbCopies = NbCopies - 10;
    Facture = (NbCopies * NextCopiesPrice) + (10 * TenFirstPrice);

}
else if (NbCopies >= 30)//Si le nombre de copies est supérieur ou égal à 30(10 premières+les 20 suivantes.
{ NbCopies = NbCopies - 30;
    Facture = (NbCopies  * 0.08 + (10 * TenFirstPrice)+(20*NextCopiesPrice;

}

Console.WriteLine("le montant de la facture s'élève à: " + Facture + " $ .");//On inscrit en console le montant de la facture.
Console.ReadLine();


