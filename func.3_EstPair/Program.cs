﻿//déclaration de la fonction qui indique si le nombre est pair ou impair.Elle prend un entier en argument.
int IsEven(int Nb)
{
    bool Pair = false;
//Analyse du nombre à l'aide du modulo.
    if(Nb % 2 == 0) { Pair= true; }
    //Afichge du résultat.
    if(Pair==true){ Console.WriteLine($"Le nombre: {Nb} est pair."); }
    else if(Pair==false) { Console.WriteLine($"Le nombre: {Nb} est impair."); }
    return Nb;
}//Apel de la fonction avec une entrée utilisateur en paramètre.
Console.Write("indiquez un nombre.");
int Number= int.Parse(Console.ReadLine());
//Apel de la fonction avec des nombres donnés.
IsEven(Number);
IsEven(43);
IsEven(42);

