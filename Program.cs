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
            Step step = new Step(currentLettersGuessed, currentLettersRight, theWord, parachute, amountOfTimesWrong); 

            while(amountOfTimesWrong != 4 && currentLettersRight != lengthOfWordToGuess)
            {
                
                step.makeGuess();                
                amountOfTimesWrong = step.returnWrongint();
                Console.WriteLine(amountOfTimesWrong);
            }
            Console.WriteLine("\r\nGame is over! Thank you for playing :)");
        }
    }
    public class Step
    {
        public Step(List<char> currentLettersGuessed, int currentLettersRight, string theWord, Parachute parachute, int amountoftimeswrong)
        {
            clGuessed = currentLettersGuessed;
            clRight = currentLettersRight;
            Word = theWord;
            Parachute2 = parachute;
            amountOfTimesWrong = amountoftimeswrong;
        }
        List<char> clGuessed;
        int clRight;
        string Word;
        Parachute Parachute2;
        int amountOfTimesWrong;
        public int returnWrongint()
        {
            return amountOfTimesWrong;
        }
        private int printWord(List<char> guessedLetters, String randomWord)
        {
            int counter = 0;
            int rightLetters = 0;
            Console.Write("\r\n");
            foreach (char c in randomWord)
            {
                if (guessedLetters.Contains(c))
                {
                    Console.Write(c + " ");
                    rightLetters += 1;
                }
                else
                {
                    Console.Write("  ");
                }
                counter += 1;
            }
            //Console.Write("\r\n");
            return rightLetters;
        }
        
        public void makeGuess()
        {
            Console.Write("Letters guessed so far: ");
            foreach (char letter in clGuessed)
            {
                Console.Write(letter + " ");
            }
            Console.WriteLine("Guess a Letter [a-z]: ");
            char letterGuessed = Console.ReadLine()[0];
            if (clGuessed.Contains(letterGuessed))
            {
                Console.WriteLine("Already Guessed");
            }
            if (clGuessed.Contains(letterGuessed))
                {
                    Console.WriteLine("\r\n You have already guessed this letter");
                    Parachute2.getParachute(amountOfTimesWrong);
                    clRight = printWord(clGuessed, Word);
                    printLines(Word);
                }
                else
                {
                    // Check if letter is in randomWord
                    bool right = false;
                    for (int i = 0; i < Word.Length; i++) { if (letterGuessed == Word[i]) { right = true; } }

                    // User is right
                    if (right)
                    {
                        Parachute2.getParachute(amountOfTimesWrong);
                        // Print word
                        clGuessed.Add(letterGuessed);
                        clRight = printWord(clGuessed, Word);
                        Console.WriteLine("\r\n");
                        printLines(Word);
                    }
                    // User was wrong af
                    else
                    {
                        amountOfTimesWrong += 1;
                        
                        clGuessed.Add(letterGuessed);
                        // Update the drawing
                        Parachute2.getParachute(amountOfTimesWrong);
                        // Print word
                        clRight = printWord(clGuessed, Word);
                        Console.WriteLine("\r\n");
                        printLines(Word);
                    }
                }
        }
        private void printLines(String randomWord)
        {
            Console.WriteLine("\r");
            foreach (char c in randomWord)
            {
                Console.OutputEncoding = System.Text.Encoding.Unicode;
                Console.Write("\u0305  ");
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

