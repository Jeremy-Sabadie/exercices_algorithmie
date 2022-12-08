
//_________________________Les variables___________________________
Console.Write("Quel est votre age?");//____________ On récupère l'age du conducteur.
int Age = int.Parse(Console.ReadLine());// _______________On récupère l'age du conducteur.
//On récupère l'ancièneté de permis du conducteur.
Console.Write("Depuis combien de temps avez-vous votre permis en nombre d'années?");//On demande l'ancienneté du conducteur.
int SeniorityLicence = int.Parse(Console.ReadLine());//_____________On récupère l'ancienneté du conducteur.

int Point = 0;//______________ Un compteur de points est défini à 0 pour commencer est sera incrémenté de un si une des conditions est remplie.


//Le conducteur as t-il déjà eu un accident?
Console.Write("Combien d'accident avez-vous déjà eu?");//On demande le nombre d'accidents.
int Accident = int.Parse(Console.ReadLine());//On récupère et on stocke dans une variable le nombre d'accidents.
//On récupère l'ancieneté du conducteur pour la comparer.
Console.WriteLine("Depuis combien de temps êtes vous assurer chez nous?");//On demande l'anciennetée du conducteur.
int CompagnieFidelity = int.Parse(Console.ReadLine());//On récupère l'anciennetée du conducteur.
//__________________________les conditions:________________________
// 1-première option:le conducteur à moins de 25 ans.
if (Age < 25)
{
    Point++;//On ajoute +1 au compter si la condition est remplie
}
//2-deuxième option: -de 25 ans et +de 2 ans de permis et au moins un accident = refusé.
if (SeniorityLicence < 2)
{
    Point++;//On ajoute +1 au compter si la condition est remplie
}
//3-troisième option: + de 25 ans et +2 ans de permis et pas d'accident = vert.
Point += Accident;
if (CompagnieFidelity >= 5)
{
    Point--;
}
//On va maintenant regarder la valeur de compteur et afficher le résultat corespondant à l'aide d'une switch case.
switch (Point)
{
    case 0://Si le nombre de points dans le compteur
        Console.WriteLine("tarif vert");
        break;
    case 1:
        Console.WriteLine("tarif orange");
        break;
    case 2:
        Console.WriteLine("tarif rouge");
        break;
    case -1:
        Console.WriteLine("tarif bleu!");
        break;
    default:
        Console.WriteLine("refusé");
        break;
}


