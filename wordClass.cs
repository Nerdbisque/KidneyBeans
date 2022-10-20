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
            
        Random rnd = new Random();
        public string getWord()
        {
        int randIndex = rnd.Next(listWords.Count);
        string random = listWords[randIndex];   
        return random;
        }
    }           
}

