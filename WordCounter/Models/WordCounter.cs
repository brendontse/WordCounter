using System;
using System.Collections.Generic;

namespace WordCounter.Models
{
    public class Counter
    {
        public string Sentence { get; set; }
        public string Word { get; set; }
        public int Count { get; set; }
         
        public Counter(string sentence, string word)
        {
            Sentence = sentence;
            Word = word;
            Count = 0;
        }

        public string[] SplitIntoArray()
        {
            string[] sentenceAsArray = Sentence.Split(' ', '.', ',', '!', '?', '"', ';', ':', '/');
            return sentenceAsArray;
        }
    }
}

        // public string SplitSentence()
        // {
        //     // .split somewhere???
        // }