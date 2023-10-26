using TamoLogic;

Tamgotchi tamo = new();


Console.WriteLine("VÄLJ DIN TAMAGOCHI NAMN!");
tamo.name = Console.ReadLine();
Console.WriteLine($"Nice, {tamo.name}");
Console.ReadLine();




while (tamo.isAlive == true)
{

    Console.WriteLine("klicka f för att mata, klicka t för Teach, klicka h för Hi");

    tamo.Tick();
    tamo.Printstats();

    string answer = Console.ReadLine().ToUpper();

    if (answer == "F")
    {
        tamo.Feed();
    }
    else if (answer == "T")
    {  
        Console.WriteLine("word word?");
        string word = Console.ReadLine();                                                                                                        
        tamo.Teach(word);
    }
    else if (answer == "H" && tamo.wereTaghut == true)
    {
       string word = tamo.Hi();
       Console.WriteLine($"{word}");
        
    }
    else
    {
        Console.WriteLine("du skrev fel dumbass.");
    }


}


Console.WriteLine("din tamagochi dog! :( ");
Console.ReadLine();


