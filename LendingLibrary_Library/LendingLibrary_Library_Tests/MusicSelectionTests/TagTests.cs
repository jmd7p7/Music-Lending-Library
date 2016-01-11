using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using LendingLibrary_Library.MusicSelection;

namespace LendingLibrary_Library_Tests.MusicSelectionTests
{
    [TestClass]
    public class TagTests
    {
        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException), "In class tag, constructor.  String argument tagName cannot be null.")]
        public void Tag_Constructor_ArgumentTagNameIsNull_ThrowsArgumentNullException()
        {
            //Arrange
            Tag myTag;

            //Act
            myTag = new Tag(null);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException), "In class tag, constructor.  String argument tagName cannot be empty.")]
        public void Tag_Constructor_ArgumentTagNameIsEmpty_ThrowsArgumentException()
        {
            //Arrange
            Tag myTag;

            //Act
            myTag = new Tag("");
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException), "In class tag, constructor.  String argument tagName cannot be white space.")]
        public void Tag_Constructor_ArgumentTagNameIsWhiteSpace_ThrowsArgumentException()
        {
            //Arrange
            Tag myTag;

            //Act
            myTag = new Tag("  ");
        }

        [TestMethod]
        public void Tag_ConstructorSetFieldTagNameCorrectly()
        {
            //Arrange
            Tag myTag;

            //Act
            myTag = new Tag(" Lent ");

            //Assert
            Assert.AreEqual("Lent", myTag.TagName);
        }

        [TestMethod]
        public void Tag_ConstructorSetFieldTagName_LowerCaseCorrectly()
        {
            //Arrange
            Tag myTag;

            //Act
            myTag = new Tag(" Lent ");

            //Assert
            Assert.AreEqual("lent", myTag.TagName_LowerCase);
        }


        [TestMethod]
        public void Tag_MethodEqualsTrue()
        {
            //Arrange
            Tag myTag;
            Tag myTag2;

            //Act
            myTag = new Tag("Lent");
            myTag2 = new Tag("Lent");

            //Assert
            Assert.AreEqual(myTag, myTag2);
        }

        [TestMethod]
        public void Tag_MethodEqualsFalse()
        {
            //Arrange
            Tag myTag;
            Tag myTag2;

            //Act
            myTag = new Tag("Lent");
            myTag2 = new Tag("Advent");

            //Assert
            Assert.AreNotEqual(myTag, myTag2);
        }

        [TestMethod]
        public void Tag_MethodGetHashCodeSameForTwoEqualInstances()
        {
            //Arrange
            Tag myTag;
            Tag myTag2;

            //Act
            myTag = new Tag("Lent");
            myTag2 = new Tag("Lent");

            //Assert
            Assert.AreEqual(myTag.GetHashCode(), myTag2.GetHashCode());
        }

        [TestMethod]
        public void Tag_MethodGetHashCodeDifferentForTwoNotEqualInstances()
        {
            //Arrange
            Tag myTag;
            Tag myTag2;

            //Act
            myTag = new Tag("Lent");
            myTag2 = new Tag("Advent");

            //Assert
            Assert.AreNotEqual(myTag.GetHashCode(), myTag2.GetHashCode());
        }
    }
}
