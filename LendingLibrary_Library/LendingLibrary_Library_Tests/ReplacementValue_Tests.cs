using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using LendingLibrary_Library.MusicSelection;
using System.Collections.Generic;

namespace LendingLibrary_Library_Tests
{
    [TestClass]
    public class ReplacementValue_Tests
    {
        [TestMethod]
        [ExpectedException(typeof(ArgumentException), "In class ReplacementValue, constructor. The replacement value must contain text.")]
        public void TestReplacementValueConstructorWithNullReplacementValueParameter_ThrowsArgumentException()
        {
            //Arrange
            ReplacementValue myReplacementValue;

            //Act
            myReplacementValue = new ReplacementValue(null, "522bb79455449d881b004d27");
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException), "In class ReplacementValue, constructor. The replacement value must contain text.")]
        public void TestReplacementValueConstructorWithEmptyStringReplacementValueParameter_ThrowsArgumentException()
        {
            //Arrange
            ReplacementValue myReplacementValue;

            //Act
            myReplacementValue = new ReplacementValue("", "522bb79455449d881b004d27");
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException), "In class ReplacementValue, constructor. The replacement value must contain text.")]
        public void TestReplacementValueConstructorWithWhiteSpaceReplacementValueParameter_ThrowsArgumentException()
        {
            //Arrange
            ReplacementValue myReplacementValue;

            //Act
            myReplacementValue = new ReplacementValue(" ", "522bb79455449d881b004d27");
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException), "In class ReplacementValue, constructor. The InstidutionId must contain text.")]
        public void TestReplacementValueConstructorWithNullInstitutionIdParameter_ThrowsArgumentException()
        {
            //Arrange
            ReplacementValue myReplacementValue;

            //Act
            myReplacementValue = new ReplacementValue("Advent", null);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException), "In class ReplacementValue, constructor. The InstidutionId must contain text.")]
        public void TestReplacementValueConstructorWithEmptyStringInstitutionIdParameter_ThrowsArgumentException()
        {
            //Arrange
            ReplacementValue myReplacementValue;

            //Act
            myReplacementValue = new ReplacementValue("Advent", "");
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException), "In class ReplacementValue, constructor. The InstidutionId must contain text.")]
        public void TestReplacementValueConstructorWithWhiteSpaceInstitutionIdParameter_ThrowsArgumentException()
        {
            //Arrange
            ReplacementValue myReplacementValue;

            //Act
            myReplacementValue = new ReplacementValue("Advent", " ");
        }

        [TestMethod]
        public void TestReplacementValueConstructorWhiteSpaceTrimmedFromReplacementValue()
        {
            //Arrange
            ReplacementValue myReplacementValue;

            //Act
            myReplacementValue = new ReplacementValue("  Advent  ", "522bb79455449d881b004d27");

            //Assert
            Assert.AreEqual("Advent", myReplacementValue._ReplacementValue);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException), "In class ReplacementValue, AddInsitutionId(). Attempted to add an institutionId that already exists in the list.")]
        public void TestReplacementValue_AddInstitutionIdThatAlreadyExists_ThrowsArgumentException()
        {
            //Arrange
            ReplacementValue myReplacementValue =
                new ReplacementValue("Advent", "522bb79455449d881b004d27");

            //Act
            myReplacementValue.AddInsitutionId("522bb79455449d881b004d27");
        }

        [TestMethod]
        public void TestReplacementValue_AddInstitutionId()
        {
            //Arrange
            ReplacementValue myReplacementValue =
                new ReplacementValue("Advent", "522bb79455449d881b004d27");

            //Act
            myReplacementValue.AddInsitutionId("999bb79455449d881b004d27");

            //Assert
            CollectionAssert.AreEqual(new List<String> { "522bb79455449d881b004d27", "999bb79455449d881b004d27" }, 
                myReplacementValue.getInsitutionIds());

        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException), "In class ReplacementValue, RemoveInsitutionId(). Attempted to remove an institutionId (objectId) from a replacement value where that institutionId does not exist.")]
        public void TestReplacementValue_RemoveInstituionIdThatDoesNotExistInTheList_ThrowsArgumentException()
        {
            //Arrange
            ReplacementValue myReplacementValue = new ReplacementValue("Advent", "522bb79455449d881b004d27");

            //Act
            myReplacementValue.RemoveInstituionId("8899979455449d881b004d27");
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException), "In class ReplacementValue, RemoveInsitutionId(). Attempted to remove an institutionId (objectId) from a replacement value that has zero institutionIds.")]
        public void TestReplacementValue_RemoveInstitutionIdFromEmptyListOfInstitutionIds_ThrowsArgumentException()
        {
            //Arrange
            ReplacementValue myReplacementValue = new ReplacementValue("Advent", "522bb79455449d881b004d27");
            myReplacementValue.RemoveInstituionId("522bb79455449d881b004d27");

            //Act
            myReplacementValue.RemoveInstituionId("522bb79455449d881b004d27");

        }

        [TestMethod]
        public void TestReplacementValue_RemoveInstitutionId()
        {
            //Arrange
            ReplacementValue myReplacementValue = new ReplacementValue("Advent", "522bb79455449d881b004d27");
            myReplacementValue.AddInsitutionId("999bb79455449d881b004d27");

            //Act
            myReplacementValue.RemoveInstituionId("999bb79455449d881b004d27");

            //Assert
            CollectionAssert.AreEqual(new List<String> { "522bb79455449d881b004d27" }, myReplacementValue.getInsitutionIds());
        }

        [TestMethod]
        public void TestReplacementValue_getInstitutionIds()
        {
            //Arrange
            ReplacementValue myReplacementValue;

            //Act
            myReplacementValue = new ReplacementValue("Advent", "522bb79455449d881b004d27");
            myReplacementValue.AddInsitutionId("999bb79455449d881b004d27");

            //Assert
            CollectionAssert.AreEqual(new List<String> { "522bb79455449d881b004d27", "999bb79455449d881b004d27" }, myReplacementValue.getInsitutionIds());

        }

        [TestMethod]
        public void TestReplacementValue_getCout()
        {
            //Arrange
            ReplacementValue myReplacementValue;

            //Act
            myReplacementValue = new ReplacementValue("Advent", "522bb79455449d881b004d27");
            myReplacementValue.AddInsitutionId("999bb79455449d881b004d27");

            //Assert
            Assert.AreEqual(2, myReplacementValue.getCount());
        }
    }
}
