using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLSproj
{
    class Computer : Player
    {
        //Method Variable
        public string Name;
        public string selection;
        public int score;

       


        // Constructor

        public Computer()
        {
            this.Name = Name;
            score = 0;

        }

        // Member Method
        public new string ChosenGesture()
        {
            int RandomNumber(int min, int max)
            {
                Random computerChoices = new Random();
                return computerChoices.Next(min, max);

            }
            int computerChoice = RandomNumber(0, 4);
            List<string> computerGestures = new List<string>();
            computerGestures.Add("Rock");
            computerGestures.Add("Paper");
            computerGestures.Add("Scissors");
            computerGestures.Add("Lizard");
            computerGestures.Add("Spock");

            if (computerChoice == 0)
            {
                selection = computerGestures[0];
                Console.WriteLine(selection);
                return selection;

            }
            else if (computerChoice == 1)
            {
                selection = computerGestures[1];
                Console.WriteLine(selection);
                return selection;

            }
            else if (computerChoice == 2)
            {
                selection = computerGestures[2];
                Console.WriteLine(selection);
                return selection;


            }
            else if (computerChoice == 3)
            {
                selection = computerGestures[3];
                Console.WriteLine(selection);
                return selection;

            }
            else if (computerChoice == 4)
            {
                selection = computerGestures[4];
                Console.WriteLine(selection);
                return selection;

            }
            return ("invalid Choice");
        }
        public int IncreaseScore(string name)
        {
            score++;
            if (score >=2)
            {
                Console.WriteLine($"{name} wins the game");
                Console.WriteLine($"{name} final score: {score}");
                Console.ReadLine();
                return score;
            
            }
            else
            {
                Console.WriteLine($"{name} score: {score}");
                return score;

            }



            

            



        }



        // Member Method

        

    }
}
