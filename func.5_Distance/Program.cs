//. Distance
//Ecrire et tester une fonction qui calcule la distance AB entre 2 points A (x1, y1) et B(x2, y2).

//Vous vérifierez notamment que la distance entre A et B est la même que la distance entre B et A.

//Signature de la fonction Dist qui prend comme paramètres lesnentiers xA,yA,xB,yB correspondants aux abcisses et ordonnées des points A et B et qui retournera un double correspondant aub résultat du calcul de la distance des coordonnées passées en arguments.
double Dist(int xA,int yA,int xB,int yB)
{
    double Distance = Math.Sqrt((xA - xB) * (xA - xB)) + ((yA - yB) * (yA - yB));
    return Distance;
}
//Déclaration des variables qui seront utilisées en arguments lors de l'appel de la fonction Dist
int Ordo_A = 1;
int Abs_A = 6;
int Ordo_B = 4;
int Abs_B = 3;
//Appel de la fonction Dis avec Ordo_A, Abs_A, Ordo_B, Abs_B comme arguments et récupération du résultat dan Result pour pour l'affichage ultérieur :
double Result=Dist(Abs_A, Ordo_A, Abs_B, Ordo_B);
//Affichage:
Console.WriteLine($"la distance entre les dux points est de: {Result} .");
//fin.