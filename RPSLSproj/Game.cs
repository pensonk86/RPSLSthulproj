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

        Player playerOneName;
        Player playerTwoName;
        Player ComputerName;



        // Constructor

        public void GameSetup()
        {
            Console.WriteLine("Choose your opponent");

            Console.WriteLine("press 1 for computer");
            Console.WriteLine("press 2 for human.");

            string input = Console.ReadLine();
            Console.WriteLine(input);
            //capture user input as a variable to use in next if statement

            //if user entered 1
            

            
           



            playerOneName = new Human();

            playerTwoName = new Human();

            ComputerName = new Computer();


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
