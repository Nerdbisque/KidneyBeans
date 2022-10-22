using System;
using System.Collections.Generic;

namespace cse210_ParachuteMan
{
    public class guess
    {
        private parachuteMan ParachuteMan = new parachuteMan();
        private int count;
        private int trueTries = 0;
           public bool checkInput(List<char> guesses, string currentguess){
            if (guesses.Contains(currentguess[0])){
                Console.WriteLine("You already guessed that letter!");
                return true;
            }
            else {
                return false;
            }

        }

        public bool checkJumper(List<char> wordGuess, int tries){
            count = 0;
            for(int i=0;i<wordGuess.Count;i++){
                if (wordGuess[i] != '_'){
                    count++;
                }
                else{}
            }
            if (count == wordGuess.Count){
                return false;
                
            }
            else if(tries == 4){
                return false;
            }
            else {
                return true;
            }
        }

        public void printJumper(int tries)
        {
            if (tries == trueTries)
            {
                Console.Write(ParachuteMan.display(tries));
            }
            else if((tries == 1) || (tries == 2) || (tries == 3))
            {
                Console.Write(ParachuteMan.display(tries));
                trueTries++;
            }
            else
            {
                Console.Write(ParachuteMan.display(tries));
            }
        }

    }

}

