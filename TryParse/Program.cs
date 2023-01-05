
bool ParseOK;
int Nombre;
do
{
    Console.WriteLine("Entrez un nombre: ");
    ParseOK = int.TryParse(Console.ReadLine
        (), out Nombre);
} while (ParseOK == false);
    Console.WriteLine(Nombre);
