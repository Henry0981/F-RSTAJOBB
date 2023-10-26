using System.Runtime.InteropServices;

namespace TamoLogic
{
    public class Tamgotchi
    {

        int hunger = 5;
        int boredom = 5;
        public bool wereTaghut = false;
        public string name = "";
        List<string> words = new();
        Random generator = new Random();
        public bool isAlive = true;



        public void Feed()
        {
            hunger -= 2;

        }

        public string Hi()
        {
            boredom -= 4;

            int randomNum = generator.Next(0, words.Count);
            string randomWord = words[randomNum];
            return randomWord;

        }

        public void Teach(string word)
        {
            boredom -= 1;
            words.Add(word);
            wereTaghut = true;
        }

        public void Printstats()
        {
            Console.WriteLine($"hunger ={hunger}, boredoom = {boredom}");
            Console.WriteLine("din tamagochi lever!");
        }


        public void Tick()
        {
            hunger++;
            boredom++;

            if (hunger >= 10 || boredom >= 10)
            {
                isAlive = false;
            }
        }

    }
}