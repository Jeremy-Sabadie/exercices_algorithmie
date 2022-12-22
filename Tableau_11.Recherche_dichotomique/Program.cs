using System;

int[] Tableau = { 1, 2, 3, 4, 5, 6, 7 };//Tableau: tableau d'entiers trié.

//mil: nombre entier
//fin: nombre entier
//deb: nombre entier
//v: nombre entier   // la valeur recherchée
//trv: booléen

//trv ← FAUX
//deb ← 1
//fin ← longueur(L)
//tant que NON trv ET deb ⩽ fin :
//   mil ← partie_entière((deb + fin) / 2)
//   si L[mil] == v :
//      trv ← VRAI
//   sinon :
//      si v > L[mil] :
//         deb ← mil + 1
//      sinon:
//fin ← mil - 1
//      fin si
//   fin si
//fin tant que