//boucle while:
//Console.Write("Indiquez un numéro de mois.");//On demande une entrée.
//int Month = int.Parse(Console.ReadLine());//On récupère l'entrée dans la variable Month.
                                          //while (!(Month >= 1 && Month <= 12))//Condition à vérifier(tant que Month n'est pas compris entre 1 et 12).
                                          //{
                                          //    Console.Write("Indiquez un numéro de mois.");//On re demande une entrée à l'utilisateur.
//Month = int.Parse(Console.ReadLine());//Récupération de la nouvelle entrée dans la variable Month qui prend une nouvelle valeur.
//}
//Avec do while:
int Month;
do
{
    Console.Write("Indiquez un numéro de mois.");//Action à effectuer.
    Month = int.Parse(Console.ReadLine());//On récupère l'entrée de l'utilisateur.
} while (!(Month >= 1 && Month <= 12));//Instruction à vérifier( si le numéro entré n'est pas compris entre 1 et 12 on re demande une entrée à l'utilisateur.
//corection:
int Mois;
do
{
    Mois=int.Parse(Console.ReadLine());
    if (Mois < 1 || Mois > 12)
    {
        Console.WriteLine("erreur, saisir un nombre compris entre 1 et 12");
    }
}while(Mois < 1||Mois>12);
//proposition de corection do while:
//int Mois;
//do
//{
//    Mois = int.Parse(Console.ReadLine());
//    if (Mois < 1 || Mois > 12)
//    {
//        Console.WriteLine("erreur, saisir un nombre compris entre 1 et 12");
//    }
//} while (Mois < 1 || Mois > 12);



//boucle for:en général avec des entiers 
// pour(départ;condition;incrémentation);
for (int i = 0; i <= 15; i++)
{
    //Séquence d'instruction.

}