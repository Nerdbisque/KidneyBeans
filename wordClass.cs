using System;
using System.Collections.Generic;

namespace cse210_ParachuteMan
{
    public class wordList
    {
        public static class originalWord()
        {
        List<string> listWords = new List<string>
        {
            "night","orbit","wrong","liver","clerk",
            "frame","drill","sharp","brave","mango",
            "coast","theme","faith","quest","sting"      
        };
            
        Random rnd = new Random();
        int randIndex = rnd.Next(listWords.Count);
        int random = listWords[randIndex];   
        }

        public static class getWord()
    
    }           
}

