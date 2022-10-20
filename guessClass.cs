using System;
using System.Collections.Generic;

namespace cse210_ParachuteMan
{
    public class guess
    {
        randomWord listClass = new randomWord();
        
        public string[] getArray()
        {

        string theWord = listClass.getWord();
        
        string[] newWord = new string[theWord.Length];

        for (int i = 0; i < theWord.Length; i++)
        {
            newWord[i] = theWord.Substring(i, 1); 
        }
        
        string[] hiddenWord = new string[theWord.Length];

        for (int h = 0; h < theWord.Length; h++)
        {
            hiddenWord[h] = "_ ";
        }
            return hiddenWord;
        }

        public string[] checkGuess(string letter)
        {
    
            return ;
        }

    }

}

