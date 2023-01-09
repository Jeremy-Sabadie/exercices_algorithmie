// Permutation de deux variables sans la fonction.
string a = "1";
string b = "-2";
Console.WriteLine($"avant la permutation la variable a vaut: {a} et: ");
Console.WriteLine($"avant la permutation la variable b vaut: {b} et: ");

string tmp = "0";
tmp = a;

a = b;
b = tmp;
Console.WriteLine($"aprés la permutation la variable a vaut: {a} et: ");
Console.WriteLine($"aprés la permutation la variable b vaut: {b} et: ");
// Fonction Permutation qui permute les valeurs de deux variables contenant des entiers.
static void Permutation(ref int VarA, ref int varB)
{
    string Tmp = VarA;
    string VarA = varB;
    varB = Tmp;

}
Console.WriteLine($"avant la permutation la variable a vaut: {VarA} et: b vaut {varB}");
Console.WriteLine($"aprés la permutation la variable a vaut: {VarA} et: b vaut {varB}");
Permutation(1, 5);
Console.WriteLine($"avant la permutation la variable a vaut: {VarA} et: b vaut {varB}");
Console.WriteLine($"aprés la permutation la variable a vaut: {VarA} et: b vaut {varB}");



