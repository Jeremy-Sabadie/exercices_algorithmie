// See https://aka.ms/new-console-template for more information

//on demande le sexe de la personne:
Console.WriteLine("Donnez votre genre:h pour hommet et f pour femme.");
char Genre = Console.ReadKey().KeyChar;
//On demande l'age de la personne:
Console.Write("entrez votre age:");
string Age = Console.ReadLine();
int AgeConvert = int.Parse(Age);



//Si sexe==femme et age supérieur ou égal à 18 et age inférieur ou égal à 35
if ((Genre == 'f' && AgeConvert >= 18 && AgeConvert <= 35) || (Genre == 'h' && AgeConvert > 20))
{
    Console.WriteLine("impôt!");
}
//On affiche  "impôt!"
//Si sexe est éga à homme et agesupérieur à20:
else
{
    Console.WriteLine("pas d'impôt");
}


    //On affiche  "impôt!"
    Console.ReadLine();