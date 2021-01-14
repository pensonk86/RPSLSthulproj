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
         

        // Constructor
        public Human()
        {
            
            score = 0;


        }



        public void ChosenGesture() // what would a better name be?
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
                        base.ChosenGesture = GestureOptions[0]; //rock
                        goodInput = true;
                        break;
                    case "2":
                    case "two":
                        base.ChosenGesture = GestureOptions[1]; //paper
                        goodInput = true;
                        break;
                    case "3":
                    case "three":
                        base.ChosenGesture = GestureOptions[2]; //Scissors
                        goodInput = true;
                        break;
                    case "4":
                    case "four":
                        base.ChosenGesture = GestureOptions[3]; //Lizard
                        goodInput = true;
                        break;
                    case "5":
                    case "five":
                        base.ChosenGesture = GestureOptions[4]; //Spock
                        goodInput = true;
                        break;
                    default:
                        Console.WriteLine("invalidChoice");
                        break;
                }
                
            }
                            // Member Method

        }
       
        
            
            


        

        public override int IncreaseScore(string playerOne, string playerTwo, string computerName)
        {

            score++; // where's is my new home?
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


            throw new NotImplementedException();
        }
    }
}
