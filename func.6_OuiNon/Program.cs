//Fonction qui demande si marié et qui  retourne la réponse sous forme de  strig.
string isMaried(string maried)
{
    do
    {
        Console.WriteLine("Etes-vous marié?");
        maried = Console.ReadLine();
        if (maried != "Oui" && maried != "Non")
        {
            Console.WriteLine("Répondez par Oui ou Non!");
        }
        else if (maried == "Oui") { Console.WriteLine("Dommage!"); }
        else { Console.WriteLine("Ok il est encore temps!"); }
        return maried;
    } while (maried != "Oui" && maried != "Non");
    //Fin de la fonction isMaried.
     
    //Fonction haveChild qui demande si a des enfant et retourne le résutat sous forme de string.
    string haveChild(string child){
        Console.WriteLine("Avez-vous des enfants?");
        child = Console.ReadLine();
        if (child != "Oui" && child != "Non")
        {
            Console.WriteLine("Répondez par Oui ou Non!");
        }
        else if (child == "Oui") { Console.WriteLine("Dommage aussi!"); }
        else { Console.WriteLine("Pensez contraception!"); }
            return child;
        }
    //Fin de la fonction haveChild.
    //Définition des vaiables qui serviront de paramètres lors de la déclaration de la fonction answer:
        string UserWedding = isMaried("Oui");
        string UserChild = haveChild("Oui");
    //Appel déclaration de la fonction Answer qui prend comme paramètres les variables déclarées au dessus et qui retourne  une string correspondante à la valeur de la variable maried.
        string Answer(string maried,string child) {
        return maried;
        }
    