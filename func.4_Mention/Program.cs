string Mention(int Note)
{
    string Mention = "";
    if (Note >= 16) { Mention = "Très Bien"; }
    else if (Note >= 14 && Note < 16) { Mention = "Bien"; }
    else if (Note >= 12 && Note < 14) { Mention = "Assez Bien"; }
    else if (Note >= 10 && Note < 12) { Mention = "Passable"; }
    else if (Note < 10) { Mention = "Echec"; }
    return Mention;
}
int[] NotesTab = { 1, 2, 3, 5, 8, 13, 21 };
for (int i = 0; i < NotesTab.Length; i++)
{

    Console.WriteLine($"{NotesTab[i]} = {Mention(NotesTab[i])}");
}
