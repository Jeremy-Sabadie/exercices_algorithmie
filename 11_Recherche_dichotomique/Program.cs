

//Pseudo code :

//VARIABLE
//Tab : tableau d'entiers trié
using System.ComponentModel.DataAnnotations.Schema;

int[] Tab = { 38, 45, 64, 75, 84, 87 };
//End : nombre entier (dernier item du tableau.

//deb : nombre entier

//fonction MiddleArray pour trouver lemilieu d'un tableau :
int MiddleArray( int debut, int fin){
    
    int Mid = (debut + fin) / 2;
    return Mid ;
}
int[] Tab_1 = { 38, 45, 64, 75, 84, 87 };
MiddleArray(0,Tab_1.Length-1);


int x= int.Parse(Console.ReadLine());
//tr ← FAUX
bool Trouve = false;
//tant que trouve == FAUX et que Start <= End :
// middle = partie_à conserver((deb + fin) / 2)
// si t[middle] == x :
//  tr = vrai
// sinon:
//si x > t[middle] :
//   Start ← middle + 1
//  sinon:
//End ← middle - 1
//renvoyer la valeur de trouve
//FIN