﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLSproj
{
    class Program
    {
        static void Main(string[] args)
        {
            Game game = new Game();
            game.RunSinglePlayerGame();
            Console.ReadLine();
            

        }
    }
}
