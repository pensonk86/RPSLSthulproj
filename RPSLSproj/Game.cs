using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLSproj
{
    class Game
    {
        // Method Variable
        // Game has to be won based on a minimum of "best of 3" to decide winner

        Player playerOne;
        Player playerTwo;
        Player computerName;
        Player playerTotal;
        public int score;

        //Player ComputerName;
        //Player playerTotal;


        // Constructor
        public Game()
        {
            playerOne = new Human();
            playerTwo = new Human();
            score = 0;
            
            
        }

        //member methods
        public string HowManyPlayers()
        {
            Console.WriteLine("1 or 2 players?");
            string playerTotal = Console.ReadLine();
            

            //capture user input as a variable to use in next if statement
            //if user entered 1
            if (playerTotal == "1")
            {
                //make p2 a computer
                Console.WriteLine($"{playerTotal}? Single Player Selected");
                Console.WriteLine("---");

                
            }
            else if (playerTotal == "2")
            {
                //make computer a human
                Console.WriteLine($"{playerTotal}? Two Players Selected");
                Console.WriteLine("---");

                
            }
            else
            {
                Console.WriteLine("enter 1 or 2");
                HowManyPlayers();

            }
                return ("invalid selection");



        }

        
        public void RunSinglePlayerGame()
        {
            Welcome();

            while (playerOne.score < 2 && computerName.score < 2)
            {
                CheckScore(playerOne, computerName);
                Console.WriteLine("Rock, Paper, Scissors, Lizzard, or Spock");
                playerOne.GestureOptions();
                computerName.computerGestures();

                if (playerOne.GestureOptions == computerName.computerGestures)
                {
                    Console.WriteLine("Tie");

                }
                else if (playerOne.GestureOptions = "Rock" && computerName.computerGestures = "Paper")
                {
                    Console.WriteLine($"{computerName} wins round");
                    computerName.IncreaseScore(computerName);

                }
                else if (playerOne.GestureOptions = "scissors" && computerName.computerGestures = "Paper")
                {
                    Console.WriteLine($"{playerOne} wins round");
                    playerOne.IncreaseScore(playerOne);
                      
                }
                else if (playerOne.GestureOptions = "lizzard" && computerName.computerGestures = "Paper")
                {
                    Console.WriteLine($"{playerOne} wins round");
                    playerOne.IncreaseScore(playerOne);

                }
                else if (playerOne.GestureOptions = "Spock" && computerName.computerGestures = "paper")
                {

                    Console.WriteLine($"{computerName} wins round");
                    computerName.IncreaseScore(computerName);

                }
                else if (playerOne.GestureOptions = "Paper" && computerName.computerGestures = "rock")
                {
                    Console.WriteLine($"{playerOne} wins round");
                    playerOne.IncreaseScore(playerOne);

                }
                else if (playerOne.GestureOptions = "scissors" && computerName.computerGestures = "Rock")
                {
                    Console.WriteLine($"{computerName} wins round");
                    computerName.IncreaseScore(computerName);

                }
                else if (playerOne.GestureOptions = "Lizard" && computerName.computerGestures = "Rock")
                {
                    Console.WriteLine($"{computerName} wins round");
                    computerName.IncreaseScore(computerName);

                }
                else if (playerOne.GestureOptions = "Spock" && computerName.computerGestures = "Rock")
                {
                    Console.WriteLine($"{playerOne} wins round");
                    playerOne.IncreaseScore(playerOne);

                }
                else if (playerOne.GestureOptions = "Rock" && computerName.computerGestures = "Scissors")
                {
                    Console.WriteLine($"{playerOne} wins round");
                    playerOne.IncreaseScore(playerOne);

                }
                else if (playerOne.GestureOptions = "paper" && computerName.computerGestures ="Scissors")
                {
                    Console.WriteLine($"{computerName} wins round");
                    computerName.IncreaseScore(computerName);


                }
                else if (playerOne.GestureOptions = "Liazard" && computerName.computerGestures = "Scissors")
                {
                    Console.WriteLine($"{computerName} wins round");
                    computerName.IncreaseScore(computerName);


                }
                else if (playerOne.GestureOptions = "Spock" && computerName.computerGestures = "Scissors")
                {
                    Console.WriteLine($"{playerOne} wins round");
                    playerOne.IncreaseScore(playerOne);


                }
                else if (playerOne.GestureOptions = "Rock" && computerName.computerGestures = "Lizard")
                {
                    Console.WriteLine($"{playerOne} wins round");
                    playerOne.IncreaseScore(playerOne);


                }
                else if (playerOne.GestureOptions = "Paper" && computerName.computerGestures = "Lizard")
                {
                    Console.WriteLine($"{computerName} wins round");
                    computerName.IncreaseScore(computerName);


                }
                else if (playerOne.GestureOptions = "Scissors" && computerName.computerGestures = "Lizard")
                {
                    Console.WriteLine($"{computerName} wins round");
                    computerName.IncreaseScore(computerName);


                }
                else if (playerOne.GestureOptions = "Spock" && computerName.computerGestures = "Lizard")
                {
                    Console.WriteLine($$"{computerName} wins round");
                    computerName.IncreaseScore(computerName);

                }
                else if (playerOne.GestureOptions = "Rock" && computerName.computerGestures = "Spock")
                {
                    Console.WriteLine($"{computerName} wins round");
                    computerName.IncreaseScore(computerName);


                }
                else if (playerOne.GestureOptions = "Paper" && computerName.computerGestures = "Spock")
                {
                    Console.WriteLine($"{playerOne} wins round");
                    playerOne.IncreaseScore(playerOne);


                }
                else if (playerOne.GestureOptions = "Scissors" && computerName.computerGestures = "Spock")
                {
                    Console.WriteLine($"{computerName} wins round");
                    computerName.IncreaseScore(computerName);


                }
                else if (playerOne.GestureOptions = "Lizard" && computerName.computerGestures = "Spock")
                {
                    Console.WriteLine($"{playerOne} wins round");
                    playerOne.IncreaseScore(playerOne);

                }
                

            }
            public void RunMultiPlayerGame(string playerOne, string playerTwo);
            {
                Welcome();
               
                while (playerOne.score < 2 && playerTwo.score <2)
                {
                    CheckScore(playerOne, playerTwo);
                    Console.WriteLine("Rock, Paper, Scissors, Lizzard, or Spock");
                    playerOne.GestureOptions();
                    playerTwo.GestureOptions();
                }

                if (playerOne.ChosenGesture == playerTwo.ChosenGesture)
                {

                    Console.WriteLine("It's a tie");

                }
                else if (playerOne.ChosenGesture = "rock" && playerTwo.ChosenGesture = "paper")
                {
                    Console.WriteLine("player 2 wins round");
                    playerTwo.IncreaseScore(playerTwo);
                }
                else if (playerOne.ChosenGesture = "scissors" && playerTwo.ChosenGesture = "paper")
                {
                    Console.WriteLine("playerOne wins round");
                    playerOne.IncreaseScore(playerOne);


                }
                else if (playerOne.ChosenGesture = "Lizard" && playerTwo.ChosenGesture = "Paper")
                {
                    Console.WriteLine("playerOne wins round");
                    playerOne.IncreaseScore(playerOne);


                }
                else if (playerOne.ChosenGesture = "Spock" && playerTwo.ChosenGesture = "Paper")
                {
                    Console.WriteLine("playerTwo wins round");
                    playerTwo.IncreaseScore(playerTwo);

                }
                else if (playerOne.ChosenGesture = "Paper" && playerTwo.ChosenGesture = "Rock")
                {
                    Console.WriteLine("playerOne wins round");
                    playerOne.IncreaseScore(playerOne);


                }
                else if (playerOne.ChosenGesture = "Scissors" && playerTwo.ChosenGesture = "Rock")
                {
                    Console.WriteLine("playerTwo wins round");
                    playerTwo.IncreaseScore(playerTwo);


                }
                else if (playerOne.ChosenGesture = "Lizard" && playerTwo.ChosenGesture = "Rock")
                {
                    Console.WriteLine("playerTwo wins round");
                    playerTwo.IncreaseScore(playerTwo);


                }
                else if (playerOne.ChosenGesture = "Spock" && playerTwo.ChosenGesture = "Rock")
                {
                    Console.WriteLine("playerOne wins round");
                    playerOne.IncreaseScore(playerOne);

                }
                else if (playerOne.ChosenGesture = "Rock" && playerTwo.ChosenGesture = "Scissors")
                {

                    Console.WriteLine("playerOne wins round");
                    playerOne.IncreaseScore(playerOne);

                }
                else if (playerOne.ChosenGesture = "Paper" && playerTwo.chosenGesture = "Scissors")
                {
                    Console.WriteLine("playerTwo wins round");
                    playerTwo.IncreaseScore(playerTwo);


                }
                else if (playerOne.ChosenGesture = "Lizard" && playerTwo.ChosenGesture ="Scissors")
                {

                    Console.WriteLine("playerTwo wins round");
                    playerTwo.IncreaseScore(playerTwo);

                }
                else if (playerOne.ChosenGesture = "Spock" && playerTwo.ChosenGesture = "Scissors")
                {
                    Console.WriteLine("PlayerOne wins round");
                    playerOne.IncreaseScore(playerOne);


                }
                else if (playerOne.ChosenGesture = "Rock" && playerTwo.ChosenGesture = "Lizard")
                {
                    Console.WriteLine("playerOne wins round");
                    playerOne.IncreaseScore(playerOne);


                }
                else if (playerOne.ChosenGesture = "Paper" &&  playerTwo.ChosenGesture = "Lizard")
                {
                    Console.WriteLine("playerTwo wins round");
                    playerTwo.IncreaseScore(playerTwo);


                }
                else if (playerOne.ChosenGesture = "Scissors" && playerTwo.ChosenGesture = "Lizard")
                {
                    Console.WriteLine("playerOne wins round");
                    playerOne.IncreaseScore(playerOne);


                }
                else if (playerOne.ChosenGesture = "Spock" && playerTwo.ChosenGesture = "Lizard")
                {
                    Console.WriteLine("playerTwo wins round");
                    playerTwo.IncreaseScore(playerTwo);


                }
                else if (playerOne.ChosenGesture = "Rock" && playerTwo.ChosenGesture = "Spock")
                {
                    Console.WriteLine("playerTwo wins round");
                    playerTwo.IncreaseScore(playerTwo);


                }
                else if (playerOne.ChosenGesture = "Paper" && playerTwo.ChosenGesture = "Spock")
                {
                    Console.WriteLine("playerOne wins round");
                    playerOne.IncreaseScore(playerOne);


                }
                else if (playerOne.ChosenGesture = "Scissors" && playerTwo.ChosenGesture = "Spock")
                {
                    Console.WriteLine("playerTwo wins round");
                    playerTwo.IncreaseScore(playerTwo);


                }
                else if (playerOne.ChosenGesture ="Lizard" && playerTwo.ChosenGesture = "Spock")
                {
                    Console.WriteLine("playerOne wins round");
                    playerOne.IncreaseScore(playerOne);

                }





            }

        }
        public void Welcome()
        {
            Console.WriteLine("Welcome to rock, paper, scissors, lizard, spock!");
            //Console.WriteLine("Please select 1 for human or 2 for computer");
            Console.ReadLine();


        }

        public int ChooseHuman()
        {

            for (int i = 1; i < 1; i++)
            {
                Console.WriteLine("press" + i + " for Human");

            }
            string input = Console.ReadLine();
            return Int32.Parse(input);


        }

        public int ChooseComputer()
        {
            for (int i = 2; i < 2; i++)
            {
                Console.WriteLine("Press" + i + " for Computer");
            }
            string input = Console.ReadLine();
            return Int32.Parse(input);

        }
















       

        







    }

        

       
        









            







        
           
        





















    
}
