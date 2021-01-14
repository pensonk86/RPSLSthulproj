using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLSproj
{
    abstract class Player
    {  //Method Variable (Has A)
       // Somehow assign player values
       // assign player a gesture

        public List<Gesture> GestureOptions;
        public Gesture ChosenGesture;
        public string name;
        public int score;
       
        

       
        


        // Constructor

        public Player()
        {
            Gesture Rock = new Gesture("Rock");
            Gesture Paper = new Gesture("Paper");
            Gesture Scissors = new Gesture("Scissors");
            Gesture Lizard = new Gesture("Lizard");
            Gesture Spock = new Gesture("Spock");


            GestureOptions = new List<Gesture>();
            GestureOptions.Add(Rock);
            GestureOptions.Add(Paper);
            GestureOptions.Add(Scissors);
            GestureOptions.Add(Lizard);
            GestureOptions.Add(Spock);


        }


        // Member Method
        public abstract int IncreaseScore(string playerOne, string playerTwo, string computerName);

        


    }
}
