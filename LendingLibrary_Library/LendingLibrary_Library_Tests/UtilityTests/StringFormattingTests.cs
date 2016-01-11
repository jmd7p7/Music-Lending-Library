using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using LendingLibrary_Library.Utility;
namespace LendingLibrary_Library_Tests.UtilityTests
{
    [TestClass]
    public class StringFormattingTests
    {
        [TestMethod]
        public void TestCapitalize_NullArgument_ReturnsEmptyString()
        {
            //Assert
            Assert.AreEqual(String.Empty, StringFormatting.Capitalize(null));
        }

        [TestMethod]
        public void TestCapitalize_EmptyStringArgument_ReturnsEmptyString()
        {
            //Assert
            Assert.AreEqual(String.Empty, StringFormatting.Capitalize(""));
        }

        [TestMethod]
        public void TestCapitalize_WhiteSpaceArgument_ReturnsEmptyString()
        {
            //Assert
            Assert.AreEqual(String.Empty, StringFormatting.Capitalize("   "));
        }

        [TestMethod]
        public void TestCapitalize_SingleCharacter()
        {
            //Assert
            Assert.AreEqual("G", StringFormatting.Capitalize("g"));
        }

        [TestMethod]
        public void TestCapitalize_Word()
        {
            //Assert
            Assert.AreEqual("Good", StringFormatting.Capitalize("good"));
        }

        [TestMethod]
        public void TestCapitalize_WordWithWhiteSpace_WhiteSpaceIsTrimmed()
        {
            //Assert
            Assert.AreEqual("Good", StringFormatting.Capitalize("   good  "));
        }

        [TestMethod]
        public void TestCapitalizeAll_NullArgument_ReturnsEmptyString()
        {
            //Assert
            Assert.AreEqual(String.Empty, StringFormatting.Capitalize(null));
        }

        [TestMethod]
        public void TestCapitalizeAll_EmptyStringArgument_ReturnsEmptyString()
        {
            //Assert
            Assert.AreEqual(String.Empty, StringFormatting.Capitalize(""));
        }

        [TestMethod]
        public void TestCapitalizeAll_WhiteSpaceArgument_ReturnsEmptyString()
        {
            //Assert
            Assert.AreEqual(String.Empty, StringFormatting.Capitalize("   "));
        }

        [TestMethod]
        public void TestCapitalizeAll_SingleWord()
        {
            //Assert
            Assert.AreEqual("Bob", StringFormatting.Capitalize("bob"));
        }

        [TestMethod]
        public void TestCapitalizeAll_FullName()
        {
            //Assert
            Assert.AreEqual("Dr Bob M Johnson Sr", StringFormatting.CapitalizeAllWords("dr bob m johnson sr"));
        }

        [TestMethod]
        public void TestCapitalizeAll_SentenceWithNumbers()
        {
            //Assert
            Assert.AreEqual("1st Sunday Of Advent", StringFormatting.CapitalizeAllWords("1st sunday of advent"));
        }

        [TestMethod]
        public void TestCapitalizeAll_SentenceWithPunctuation()
        {
            //Assert
            Assert.AreEqual("1st Sunday Of Advent.", StringFormatting.CapitalizeAllWords("1st sunday of advent."));
        }
    }
}
