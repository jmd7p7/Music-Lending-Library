using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using LendingLibrary_Library.MusicSelection;

namespace LendingLibrary_Library_Tests
{
    [TestClass]
    public class PrivateDispute_Tests
    {
        [TestMethod]
        [ExpectedException(typeof(ArgumentException), "In class PrivateDispute, constructor.  Argument disputedFieldName cannot be null, an empty string, or white space.")]
        public void TestPrivateDisputeConstructor_ArgumentDisputedFieldNameIsNull_ThrowsArgumentException()
        {
            //Arrange
            PrivateDispute myPrivateDispute;

            //Act
            myPrivateDispute = new PrivateDispute(null, "Easter");
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException), "In class PrivateDispute, constructor.  Argument disputedFieldName cannot be null, an empty string, or white space.")]
        public void TestPrivateDisputeConstructor_ArgumentDisputedFieldNameIsEmptyString_ThrowsArgumentException()
        {
            //Arrange
            PrivateDispute myPrivateDispute;

            //Act
            myPrivateDispute = new PrivateDispute("", "Easter");
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException), "In class PrivateDispute, constructor.  Argument disputedFieldName cannot be null, an empty string, or white space.")]
        public void TestPrivateDisputeConstructor_ArgumentDisputedFieldNameIsWhiteSpace_ThrowsArgumentException()
        {
            //Arrange
            PrivateDispute myPrivateDispute;

            //Act
            myPrivateDispute = new PrivateDispute("   ", "Easter");
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException), "In class PrivateDispute, constructor.  Argument _replacementValue cannot be null, an empty string, or white space.")]
        public void TestPrivateDisputeConstructor_ArgumentReplacementValueIsNull_ThrowsArgumentException()
        {
            //Arrange
            PrivateDispute myPrivateDispute;

            //Act
            myPrivateDispute = new PrivateDispute("Season", null);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException), "In class PrivateDispute, constructor.  Argument _replacementValue cannot be null, an empty string, or white space.")]
        public void TestPrivateDisputeConstructor_ArgumentReplacementValueIsEmptyString_ThrowsArgumentException()
        {
            //Arrange
            PrivateDispute myPrivateDispute;

            //Act
            myPrivateDispute = new PrivateDispute("Season", "");
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException), "In class PrivateDispute, constructor.  Argument _replacementValue cannot be null, an empty string, or white space.")]
        public void TestPrivateDisputeConstructor_ArgumentReplacementValueIsWhiteSpace_ThrowsArgumentException()
        {
            //Arrange
            PrivateDispute myPrivateDispute;

            //Act
            myPrivateDispute = new PrivateDispute("Season", "  ");
        }

        [TestMethod]
        public void TestPrivateDisputeConstructor_WhiteSpaceIsRemovedFromArgumentReplacementValue()
        {
            //Arrange
            PrivateDispute myPrivateDispute;

            //Act
            myPrivateDispute = new PrivateDispute("Season", "Lent   ");

            Assert.AreEqual("lent", myPrivateDispute._ReplacementValue);
        }

        [TestMethod]
        public void TestPrivateDisputeConstructor_ArgumentReplacementValueStoredAsLowerCase()
        {
            //Arrange
            PrivateDispute myPrivateDispute;

            //Act
            myPrivateDispute = new PrivateDispute("Season", "Lent");

            Assert.AreEqual("lent", myPrivateDispute._ReplacementValue);
        }
    }
}
