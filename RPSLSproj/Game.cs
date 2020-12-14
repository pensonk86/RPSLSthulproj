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

        Player player1;
        Player player2;



        // Constructor

        public Game()
        {
          
            player1 = new Human();
            player2 = new Computer();
        }


        // Member Method



    }
}
