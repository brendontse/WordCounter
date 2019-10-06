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
        public void Count_CreatesNewCount_newCount()
        {
            userInput newUserInput = new userInput("I like cats more than dogs", "cats");
            string userSentence = newUserInput.Sentence;
            Assert.AreEqual(userSentence, "I like cats more than dogs");
        }  
    }

}