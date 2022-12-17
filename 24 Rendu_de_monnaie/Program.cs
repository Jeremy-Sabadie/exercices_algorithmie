int Prix;
int Somme = 0;
do // boucle pour récupérer le prix des articles 1 par 1 jusqu'à que l'utilisateur rentre 0
{
    Console.Write("Prix article ? : ");
    Prix = int.Parse(Console.ReadLine());
    Somme = Somme + Prix;
} while (Prix != 0);

Console.WriteLine($"Vous nous devez {Somme} euros.");
Console.WriteLine("Vous donnez ? : ");
int ArgentDonne = int.Parse(Console.ReadLine());
while (Somme > ArgentDonne)
{
    Console.WriteLine($"Ce ne pas suffisant, vous nous devez {Somme} euros.");
    Console.WriteLine("Vous donnez ? : ");
    ArgentDonne = int.Parse(Console.ReadLine());
}
int ArgentARendre = ArgentDonne - Somme;
Console.WriteLine($"Nous vous devons {ArgentARendre} euros.");

// rendu de la monnaie
while (ArgentARendre >= 10)
{
    Console.WriteLine("Billet de 10 euros.");
    ArgentARendre = ArgentARendre - 10;
}
if (ArgentARendre > 5)
{
    Console.WriteLine("Billet de 5.");
    ArgentARendre = ArgentARendre - 5;
}
while (ArgentARendre > 0)
{
    Console.WriteLine("Pièce de 1 euro.");
    ArgentARendre = ArgentARendre - 1;
}
//Les tableaux
//Un tableau de 100 entiers
int[] entiers = new int[100];

//Un tableau de 5 notes (réel)
float[] notes = new float[5];

//Un tableau de 3 chaines de caractères initialisé au moment de la déclaration
string[] noms = { "Kévin", "Cloé", "Mohamed" };

