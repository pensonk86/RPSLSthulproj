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
        //Player ComputerName;
        //Player playerTotal;


        // Constructor
        public Game()
        {
            playerOne = new Human();
            playerTwo = new Human();
            
        }

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
        // Member Method
        public void RunGame()
        {
            Welcome();

            for (int i = 0; i < 2; i++)
            {



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
