int[] entiers = new int[6]//Un tableau nomé entiers est déclaré il peut contenir jusqu'à six entiers.

for (int i = 0; i < entiers.Length; i++)//Boucle for qui parcours le tableau entiers de l'item 0 jusqu'au dernier.
{
    entiers[i] = i * i;//A chaque tour de boucle on stocke la valeur de litem actuel élevé au carré dans la case du tableau actuelle.
}

for (int i = 0; i < entiers.Length; i++)//Boucle for qui parcours le tableau entiers de l'item 0 jusqu'au dernier.
{
    Console.WriteLine(entiers[i]);//L'item du tour de boucle actuel sera affiché en console.
    //Si on simplifit:
    Console.WriteLine(entiers[i]* entiers[i]);
}
