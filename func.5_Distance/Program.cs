// Signature de la fonction Distance.

double Distance(double x1, double y1, double x2, double y2)
{

    double Tmp = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
    return Math.Sqrt(Tmp);
}


double xA = 12.6;
double yA = 5.34;
double xB = 74.2;
double yB = 1;
double AB = Distance(xA, yA, xB, yB);
Console.WriteLine($"la distance entre les dux points est de: {AB} .");
double BA = Distance(xB, yB, xA, yA);
Console.WriteLine($"la distance entre les dux points est de: {BA} .");