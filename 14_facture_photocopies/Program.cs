Console.OutputEncoding = System.Text.Encoding.UTF8;// Cette ligne permet de pouvoir afficher les symboles tel que le symbole euro.

Console.Write("Indiquez le nombre de photocopies: ");
int NbCopies = int.Parse(Console.ReadLine());//Le nombre de copies demandé est récupéré dans une variable de type int.
const float TenFirstPrice = 0.10f;//Le prix des dix premières copies est défini dans une constante type float. 
const float NextCopiesPrice = 0.09f;//Le prix des copies faites apés les dix premières est défini dans une constante type float.
float Facture = 0;
if (NbCopies <= 10)//Si  le nombre de copies est supérieur ou égal à dix.
{
    Facture = NbCopies * TenFirstPrice;//Le résultat des dix première copies multipliées par le prix correspondant.
}
else if (NbCopies >= 20 && NbCopies <= 30)//Si le nombre de copies est compris entre 20 et 30.
{
    NbCopies = NbCopies - 10;//Calcul du nombre de copies apès les 10 premières.
    Facture = (NbCopies * NextCopiesPrice) + (10 * TenFirstPrice);

}
else if (NbCopies >= 30)//Si le nombre de copies est supérieur ou égal à 30(10 premières+les 20 suivantes.
{
    NbCopies = NbCopies - 30;
    Facture = (NbCopies * 0.08f) + (10 * TenFirstPrice) + (20 * NextCopiesPrice);//Le prix des copies à partir de la 31ème + le prix des 10 premières + le prix de celles après les 10 premières et avant la 31ème.
}
else if (NbCopies>10&& NbCopies < 20)//Si le nombre de copies est supérieur à 10 et inférieur à20.
{
    NbCopies = NbCopies - 10;//Ici on calcule le nombre de copies après les 10 premières.
    Facture = (10 * TenFirstPrice) + (NbCopies * NextCopiesPrice);//Le prix des 10 premières copies +le pri des suivantes jusqu'a la 20ème.
}


Console.WriteLine("le montant de la facture s'élève à: " + Facture + " $ .");//On inscrit en console le montant de la facture.
Console.ReadLine();

