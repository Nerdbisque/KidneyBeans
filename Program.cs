using System;
using System.Collections.Generic;

namespace cse210_ParachuteMan
{
    class Program{
        //Simple program to start the program by calling the StartGame method.
        static int Main(string[] args){
            Game game = new Game();
            game.StartGame ();
            return 0;
        }
    }
}
