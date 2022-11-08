using System;
using System.Collections.Generic;

namespace cse210_ParachuteMan
{
    public class randomWord
    {
        
        private List<string> listWords = new List<string>
        {
            "night","orbit","wrong","liver","clerk",
            "frame","drill","sharp","brave","mango",
            "coast","theme","faith","quest","sting"      
        };

        public string? hiddenword;
        List<char> answer = new List<char>();
        public List<char> guess = new List<char>();

        Random rnd = new Random();
        public string getWord()
        {
        int randIndex = rnd.Next(listWords.Count);
        string random = listWords[randIndex];   
        return random;
        }
        
         public void listWord(string ripWord){
            answer.AddRange(ripWord.ToLower());
        }

        public void createHiddenWord(){
            foreach (int i in answer){
                guess.Add('_');
            }
            }

        public void printGuess(){
            Console.WriteLine(string.Format("{0}", string.Join(" ", guess)));       
        }

        public int compare(List<char> listPreviousGuesses, int numberOfGuesses){
            for(int i=0;i<answer.Count;i++){
                if (listPreviousGuesses.Contains(answer[i])){
                    guess[i] = answer[i];}}
            if (answer.Contains(listPreviousGuesses[numberOfGuesses-1])){
                return 0;}
            else {
                return 1;}

        }

        public void printAnswer(){
            Console.WriteLine();
            Console.WriteLine(string.Format("{0}", string.Join(" ", answer)));
        }

    };
            
}     