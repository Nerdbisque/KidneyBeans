using System;
using System.Collections.Generic;

namespace cse210_ParachuteMan
{
    class Program
    {
        // Simple program to start the program by calling the StartGame method.
        static void Main()
        {
            Words words = new Words();
            string theWord = words.getWord();
            Parachute parachute = new Parachute(theWord);
            List<string> blanks = parachute.hiddenWord();
            Step step = new Step(theWord, blanks);
            
        }
    }
    public class Step
    {
        public Step(string theWord, string[] Blanks)
        {
            word = theWord;
            blanks = Blanks; 
        }
        string word;
        string[] blanks;
        
        public void makeGuess()
        {
            Console.WriteLine("Guess a letter [a-z]: ");
            string? guess = Console.ReadLine();
            List<string> wordArray = new List<string>();
            
            for (int i = 0; i < word.Length; i++) 
            { 
                wordArray = word
            }
            
            foreach (string letter in wordArray)
            {
                if (letter == guess)
                {
                    blanks[letter] = wordArray[letter];
                }
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
        public Parachute(string Word)
        {
            word = Word;
        }
        string word;
        public string[] hiddenWord()
        {
            string[] hidden = new string[word.Length];
            for (int p = 0; p < word.Length; p++)
                hidden[p] = "_";

            return hidden;
        }
    }
}
