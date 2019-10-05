using System;
using System.Collections.Generic;

namespace WordCounter.Models
{
    public class Counter
    {
        public string Sentence { get; set; }
        public string Word { get; set; }
        public int Count { get; set; }
         
        public Count(string sentence, string word)
        {
            Sentence = sentence;
            Word = word;
            Count = 0;
        }

        public string SplitSentence()
        {
            // .split somewhere???
        }