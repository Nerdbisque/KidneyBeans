using System;
using System.Collections.Generic;

namespace cse210_ParachuteMan
{
    public class game
    
    {
        string? playerLetter;
        bool canPlay = true;
        public void StartGame()
        {
            MainGame();    
        }
        public void MainGame()
        {
            
            while(canPlay)
            {
            
            //Show parachute and blank spaces
                // if guess is correct:
                // console.write(parachuteMan[0])
                // display _ _ _ _ _ w/ the correct guess replacing blank
                // else:
                // console.write(parachuteMan[1++])
                // display _ _ _ _ _ 
            

            Console.WriteLine("Please choose a letter a-z: "); 
            playerLetter = Console.ReadLine();
            //Check guess for the word
            //either replace the correct answer or remove a part of the hangman.
            //repeat
            }
            
        }

    }
}