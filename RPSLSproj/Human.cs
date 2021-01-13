using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLSproj
{
    class Human : Player
    {
        //Method Variable
        public string playerOneName;
        public int score;
        public string chosenGesture;

        // Constructor
        public Human()
        {
            
            score = 0;


        }



        public void choosemethod()
        {
            bool goodInput = false;
            while (!goodInput)
            {


                Console.WriteLine("Choose A Gesture");
                for (int i = 0; i < GestureOptions.Count; i++)
                {
                    Console.WriteLine((i + 1) + ":" + GestureOptions[i].Name);
                }
                string userInput = Console.ReadLine();


                switch (userInput)
                {

                    case "1":
                    case "one":
                        ChosenGesture = GestureOptions[0]; //rock
                        goodInput = true;
                        break;
                    case "2":
                    case "two":
                        ChosenGesture = GestureOptions[1]; //paper
                        goodInput = true;
                        break;
                    case "3":
                    case "three":
                        ChosenGesture = GestureOptions[2]; //Scissors
                        goodInput = true;
                        break;
                    case "4":
                    case "four":
                        ChosenGesture = GestureOptions[3]; //Lizard
                        goodInput = true;
                        break;
                    case "5":
                    case "five":
                        ChosenGesture = GestureOptions[4]; //Spock
                        goodInput = true;
                        break;
                    default:
                        Console.WriteLine("invalidChoice");
                        break;
                }
                
            }
                            // Member Method

        }
        public int IncreaseScore(string name)
        {
            score++;
            if (score >= 2)
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
        
        



        
        
        
            
        








    }
}
