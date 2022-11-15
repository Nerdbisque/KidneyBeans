using System;
using System.Collections.Generic;

namespace cse210_ParachuteMan
{
    class Program
    {
        // Simple program to start the program by calling the StartGame method.
        static void Main()
        {
            int amountOfTimesWrong = 0;
            List<char> currentLettersGuessed = new List<char>();
            int currentLettersRight = 0; 

            Words words = new Words();
            string theWord = words.getWord();
            int lengthOfWordToGuess = theWord.Length;

            Parachute parachute = new Parachute();
            Step step = new Step(currentLettersGuessed, theWord); 

            while(amountOfTimesWrong != 4 && currentLettersRight != lengthOfWordToGuess)
            {
                step.makeGuess();
                parachute.getParachute(amountOfTimesWrong);
            }   
        }
    }
    public class Step
    {
        public Step(List<char> currentLettersGuessed, string theWord)
        {
            clGuessed = currentLettersGuessed;
            Word = theWord;
        }
        List<char> clGuessed;
        string Word;
        public int printWord()
        {
            int counter = 0;
            int rightLetters = 0;
            foreach (char c in Word)
            {
                if(clGuessed.Contains(c))
                {
                    Console.Write(c + " ");
                    rightLetters++;
                }
                else
                {
                    Console.Write(" ");
                }
                counter++;
            }
            return rightLetters;
        }
        public void printLines(string Word)
        {
            
        }
        
        public void makeGuess()
        {
            Console.WriteLine("Guess a Letter [a-z]: ");
            char letterGuessed = Console.ReadLine()[0];
            if (clGuessed.Contains(letterGuessed))
            {
                Console.WriteLine("Already Guessed");
            }
        }


    }
    public class Words
    {
        private string wordList()
        {
            var Random = new Random();
            string[] listWords = 
                {
                "night","orbit","wrong","liver","clerk",
                "frame","drill","sharp","brave","mango",
                "coast","theme","faith","quest","sting"      
                };
            var randomWordnumber = Random.Next(0, listWords.Length);
            string randomWord = listWords[randomWordnumber];
            return randomWord;
        }
        public string getWord()
        {
            string randomWord = wordList();
            return randomWord;
        }
    }
    public class Parachute
    {
        public void getParachute(int amountOfTimesWrong)
        {

            string[] dudes = { @"
                 ____     
                /____\       
                \    /
                 \  /
                  O
                 /|\
                 / \

              ^^^^^^^^^^", @"
                /____\       
                \    /
                 \  /
                  O
                 /|\
                 / \

              ^^^^^^^^^^", @"
                \    /
                 \  /
                  O
                 /|\
                 / \

              ^^^^^^^^^^", @"
                 \  /
                  O
                 /|\
                 / \

              ^^^^^^^^^^", @"
                  x
                 /|\
                 / \

              ^^^^^^^^^^" 
            };
            Console.Write(dudes[amountOfTimesWrong]);
        }
    }
}

