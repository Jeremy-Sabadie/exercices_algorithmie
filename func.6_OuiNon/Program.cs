string Answer="";
string RepMaried = "";
string RepChild = "";
//Déclaration de la fonction askQuestion qui retourne la réponse en string:
string askQuestion(string ask){
    do
    {
        Console.WriteLine(ask);
        string Answer = Console.ReadLine();
        if (Answer != "Oui" && Answer != "Non")
        {
            Console.WriteLine("Répondez par Oui ou Non!");
        }
        else { Console.WriteLine("Ok"); }
    } while (Answer != "Oui" && Answer != "Non");
    return Answer;
}
//Variable savec les questions à passer en arguments:
string mariedQuestion = "Etes-vous marié?";
string childQuestion = "Avez-vous des enfants?";
//Appel de la fonction pour marié?
RepMaried = askQuestion(mariedQuestion);
//Affichage du résultat:
Console.WriteLine($"larépnse à la question{mariedQuestion}est: {Answer}");
//Appel de la fonction pour les enfants;
RepMaried = askQuestion(mariedQuestion);
//Affichage du résultat:
RepChild = askQuestion(childQuestion);
//Affichage du résultat:
Console.WriteLine($"larépnse à la question{childQuestion}est: {Answer}");

