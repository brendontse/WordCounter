using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using WordCounter.Models;

namespace WordCounter.Tests
{
    [TestClass]
    public class WordCounterTests
    {
        [TestMethod]
        public void Counter_CreatesNewCounter_newCounterSentenceExists()
        {
            Counter userInput = new Counter("I like cats more than dogs", "cats");
            string userSentence = userInput.Sentence;
            Assert.AreEqual(userSentence, "I like cats more than dogs");
        }  

        [TestMethod]
        public void Counter_CreatesNewCounter_newCounterWordExists()
        {
            Counter userInput = new Counter("I like cats more than dogs", "cats");
            string userWord = userInput.Word;
            Assert.AreEqual(userWord, "cats");
        }

        [TestMethod]
        public void Counter_BreaksCounterIntoArray_SentenceSplitIntoArray()
        {
            Counter userInput = new Counter("I like cats more than dogs", "cats");
            string[] userInputArray = userInput.SplitIntoArray();
            string[] testArray = {"I", "like", "cats", "more", "than", "dogs"};
            Assert.AreEqual(userInputArray.ToString(), testArray.ToString());
        }

        [TestMethod]
        public void Counter_CountsNumberOfOccurencesOfWord_NumberOfOccurences()
        {
            Counter userInput = new Counter("I like cats more than dogs", "cats");
            string[] userInputArray = userInput.SplitIntoArray();
            // i need to use CountWords() somehow??
            Assert.AreEqual(userInput.Occurences, 1);
        }
    }
}

// this is the error message when using dotnet test:

// PS C:\Users\Brendon\desktop\wordcounter.solution\wordcounter.tests> dotnet test
// Models\WordCounter.cs(12,23): error CS0161: 'Counter.userInput(string, string)': not all code paths return a value [C:\Users\Brendon\desktop\wordcounter.solution\WordCounter\WordCounter.csproj]