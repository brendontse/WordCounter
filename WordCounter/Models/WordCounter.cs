using System;
using System.Collections.Generic;

namespace WordCounter.Models
{
    public class Counter
    {
        public string Sentence { get; set; }
        public string Word { get; set; }
        public int Occurences { get; set; }
         
        public Counter(string sentence, string word)
        {
            Sentence = sentence;
            Word = word;
            Occurences = 0;
        }

        public string[] SplitIntoArray()
        {
            string[] sentenceAsArray = Sentence.Split(' ', '.', ',', '!', '?', '"', ';', ':', '/');
            return sentenceAsArray;
        }

        public void CountWords(string[] sentenceAsArray)
        {
            for (int i = 0; i < sentenceAsArray.Length; i++)
            {
                if (sentenceAsArray[i] == this.Word)
                {
                    this.Occurences += 1;
                }
            }
        }
    }
}
