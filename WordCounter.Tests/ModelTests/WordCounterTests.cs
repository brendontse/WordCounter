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
    }
}