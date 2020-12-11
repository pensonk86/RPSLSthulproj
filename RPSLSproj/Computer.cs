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
        public string playerTwo;

       


        // Constructor

        public Computer()
        {

        }

        public override void choosemethod()
        {
            throw new NotImplementedException();
        }

        public override bool Equals(object obj)
        {
            return obj is Computer computer &&
                   playerTwo == computer.playerTwo;
        }


        // Member Method



    }
}
