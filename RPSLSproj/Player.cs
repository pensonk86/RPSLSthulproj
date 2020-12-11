using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLSproj
{
    abstract class Player
    {  //Method Variable
       // Somehow assign player values
       // assign player a gesture

        public string scissors;
        public string rock;
        public string paper;
        public string lizard;
        public string spock;
        public string playerOne;
        public string playerTwo;

        


        // Constructor

        public Player()
        {
            
            


        }

        
        // Member Method
        public abstract void choosemethod();

        


    }
}
