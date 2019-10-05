using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using WordCounting.Models;

namespace WordCounter.Tests
{
    [TestClass]
    public class WordCounterTests
    {
        [TestMethod]
        public void Count_CreatesNewCount_newCount()
        {
            string userSentence = newCount.Sentence;
            Count newCount = new Count ("I like cats more than dogs", "cats");
            Assert.AreEqual(userSentence, "I like cats more than dogs");
        }
    }

}