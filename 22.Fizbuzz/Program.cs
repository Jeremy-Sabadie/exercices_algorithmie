
int Nb = 0;
while (Nb <= 100)
{
    Console.WriteLine(Nb);
    if (Nb % 3 == 0) { Console.WriteLine("Fizz"); }
    else if (Nb % 5 == 0) { Console.WriteLine("Buzz"); }
    //else { Console.WriteLine("")}
    //else if(Nb%5!==0&&Nb%3!==0) { Console.WriteLine("")}
    Nb++;
}


