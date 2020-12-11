using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLSproj
{
    class Gesture : Player
    {
        // Member Variable
        // 
        

        public Gesture(string scissors, string rock, string paper, string lizard, string spock )
        {
            this.scissors = scissors;
            this.rock = rock;
            this.paper = paper;
            this.lizard = lizard;
            this.spock = spock;

        }
        

        public List<Gesture> gestureList;


        // Constructor
        public Gesture()
        {
            gestureList = new List<Gesture>();

            Gesture scissors = new Gesture();
            Gesture rock = new Gesture();
            Gesture paper = new Gesture();
            Gesture lizard = new Gesture();
            Gesture spock = new Gesture();


            gestureList.Add(scissors);
            gestureList.Add(rock);
            gestureList.Add(paper);
            gestureList.Add(lizard);
            gestureList.Add(spock);

        }




        public override void choosemethod()
        {
            throw new NotImplementedException();
        }



        // Member Method




    }
}
