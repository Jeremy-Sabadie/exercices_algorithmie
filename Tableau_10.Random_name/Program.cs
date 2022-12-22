string[]Tableau= new string[12];//Création du tableau pouvant contenir 12 item maximum.
for (int i = 0; i < 12; i++)//On parcours les 12 items du tableau.
{
    //On demande une entrée.
    Console.WriteLine("Inscrivez un nom:");
    //On récupère l'entrée dan la variable Name.
    string Name = string.Format(Console.ReadLine());
    //On parcours une nouvelle fois le tableau pour traiter l'entrée de l'utilisateur.
    for (int j = 0; j < Tableau.Length; j++)
	{
        //Si la saisie rangée dans la variable Name est différente de la valeur correspondant à l'index.
        if (Name != Tableau[j])
		{
            //L'entrée de l'utilisateur est rangée dans un index du tableau.
            Name = Tableau[i];
		}
		else if (Name == Tableau[i]) { Console.WriteLine("Ce nom existe déjà"); }//Sinon on indique en console que la valeur existe déjà.

	}

}