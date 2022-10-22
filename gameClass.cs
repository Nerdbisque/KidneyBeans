using System;
using System.Collections.Generic;

namespace cse210_ParachuteMan
{
    public class game
    
    {

        private bool isPlaying = true;
        private string chosenWord;

        // private TerminalService terminalService = new TerminalService();
        public randomWord hiddenWord = new randomWord();
        private guess jumper = new guess();
        public int tries = 0;
        public int numberOfGuesses = 0;

        private bool checkInput;

        List<char> guessedLetters = new List<char>();

        public string currentGuess = "test";


        /// <summary>
        /// Constructs a new instance of Director.
        /// </summary>
        public game()
        {
        }

        /// <summary>
        /// Starts the game by running the main game loop.
        /// </summary>
        public void StartGame()
        {
            StartUp();
            while (isPlaying)
            {
                GetInputs();
                DoUpdates();
                DoOutputs();
            }
        }


        private void StartUp()
        {
            chosenWord = hiddenWord.getWord();
            hiddenWord.listWord(chosenWord);
            hiddenWord.createHiddenWord();
            hiddenWord.printGuess();
        }
        private void GetInputs()
        {
            Console.WriteLine("\n");
            jumper.printJumper(tries);
            checkInput = true;
            while (checkInput){
                Console.Write("\nGuess a letter [a-z]: ");
                string? currentGuess = Console.ReadLine();
                checkInput = jumper.checkInput(guessedLetters, currentGuess);
            }
            guessedLetters.Add(currentGuess[0]);
            

        }


        private void DoUpdates()
        {
            numberOfGuesses = guessedLetters.Count;
            int usedTries = hiddenWord.compare(guessedLetters, numberOfGuesses);
            tries = tries + usedTries;
            isPlaying = jumper.checkJumper(hiddenWord.guess, tries);
        }


        private void DoOutputs()
        {
            Console.WriteLine("\n");
            if (isPlaying)
            {
                hiddenWord.printGuess();
            }
            else 
            {
                jumper.printJumper(tries);
                hiddenWord.printAnswer();
                Console.WriteLine("\n");
            }
  
        }
    }
}