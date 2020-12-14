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
        public string playerOne;
       

        // Constructor
        public Human()
        {
            GestureOptions.Add


        }
        
        
        public override void choosemethod()
        {
            bool goodInput = false;
            while (!goodInput)
            {


                Console.WriteLine();
                string userInput = Console.ReadLine();
              

                switch (userInput)
                {
         
                    case "1":
                    case "one":
                        goodInput = true;
                        break;
                    case "2":
                    case "two":
                        goodInput = true;
                        break;
                    default:
                        Console.WriteLine("invalidChoice");
                        break;
                }
            }
                            // Member Method

        }

        
        
            
        








    }
}
