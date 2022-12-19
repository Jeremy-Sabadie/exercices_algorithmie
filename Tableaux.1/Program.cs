using System;
Console.WriteLine("Notez le nombre de notes note:");
int NB_NOTES = int.Parse(Console.ReadLine());
int infMoyenne = 0;
int SupMoyenne = 0;
//Un tableau pour ranger les 5 notes (réel)
float[] notes = new float[NB_NOTES];

//Saisir les 5 notes
float somme = 0;
for (int i = 0; i < NB_NOTES; i++)
{
    Console.WriteLine($"Entrez une note numéro:{i + 1}");
    notes[i] = float.Parse(Console.ReadLine());

    somme = somme + notes[i];
}
//Boucle pour la comparaison des valeurs des notes pa index à celle de la moyenne.
float Moyenne = somme / NB_NOTES;
for (int i = 0; i < NB_NOTES; i++)
{
    if (notes[i] < Moyenne)//Comparaison des valeurs des notes par index à celle de  la moyenne.
    { infMoyenne += 1; }
    else if (notes[i] > Moyenne) { SupMoyenne++; }
    //Comparaison des valeurs des notes par index à celle de la moyenne.
}
//Afficher le résultat
Console.WriteLine($"La moyenne est :  {Moyenne}");

Console.WriteLine($"il y a :  {infMoyenne} notes en dessous de la moyenne.");


Console.WriteLine($"il y a :  {SupMoyenne} notes au dessus de la moyenne.");
