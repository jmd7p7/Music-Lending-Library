using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using LendingLibrary_Library.MusicSelection;
using System.Collections.ObjectModel;
using System.Collections.Generic;

namespace LendingLibrary_Library_Tests
{
    [TestClass]
    public class Dispute_Tests
    {
        [TestMethod]
        [ExpectedException(typeof(ArgumentException), "In class Dispute, constructor.  DisputedFieldName argument must have text.")]
        public void TestDisputeConstructor_DisputedFieldNameArguementIsNull_ThrowsArgumentException()
        {
            //Arrange
            Dispute myDispute;

            //Act
            myDispute = new Dispute(null, "Advent", "522bb79455449d881b004d27");
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException), "In class Dispute, constructor.  DisputedFieldName argument must have text.")]
        public void TestDisputeConstructor_DisputedFieldNameArguementIsEmpty_ThrowsArgumentException()
        {
            //Arrange
            Dispute myDispute;

            //Act
            myDispute = new Dispute("", "Advent", "522bb79455449d881b004d27");
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException), "In class Dispute, constructor.  DisputedFieldName argument must have text.")]
        public void TestDisputeConstructor_DisputedFieldNameArguementIsWhiteSpace_ThrowsArgumentException()
        {
            //Arrange
            Dispute myDispute;

            //Act
            myDispute = new Dispute("  ", "Advent", "522bb79455449d881b004d27");
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException), "In class Dispute, constructor.  ReplacementValue argument must have text.")]
        public void TestDisputeConstructor_ReplacementValueArguementIsNull_ThrowsArgumentException()
        {
            //Arrange
            Dispute myDispute;

            //Act
            myDispute = new Dispute("Season", null, "522bb79455449d881b004d27");
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException), "In class Dispute, constructor.  ReplacementValue argument must have text.")]
        public void TestDisputeConstructor_ReplacementValueArguementIsEmpty_ThrowsArgumentException()
        {
            //Arrange
            Dispute myDispute;

            //Act
            myDispute = new Dispute("Season", "", "522bb79455449d881b004d27");
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException), "In class Dispute, constructor.  ReplacementValue argument must have text.")]
        public void TestDisputeConstructor_ReplacementValueArguementIsWhiteSpace_ThrowsArgumentException()
        {
            //Arrange
            Dispute myDispute;

            //Act
            myDispute = new Dispute("Season", "  ", "522bb79455449d881b004d27");
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException), "In class Dispute, constructor.  InstitudionId argument must have text.")]
        public void TestDisputeConstructor_InstitutionIdArguementIsNull_ThrowsArgumentException()
        {
            //Arrange
            Dispute myDispute;

            //Act
            myDispute = new Dispute("Season", "Advent", null);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException), "In class Dispute, constructor.  InstitudionId argument must have text.")]
        public void TestDisputeConstructor_InstitutionIdArguementIsEmptyString_ThrowsArgumentException()
        {
            //Arrange
            Dispute myDispute;

            //Act
            myDispute = new Dispute("Season", "Advent", "");
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException), "In class Dispute, constructor.  InstitudionId argument must have text.")]
        public void TestDisputeConstructor_InstitutionIdArguementIsWhiteSpace_ThrowsArgumentException()
        {
            //Arrange
            Dispute myDispute;

            //Act
            myDispute = new Dispute("Season", "Advent", "  ");
        }

        [TestMethod]
        public void TestDisputeConstructor_DictionaryOfReplacementValuesShouldHaveLengthOfOne()
        {
            //Arrange
            Dispute myDispute;

            //Act
            myDispute = new Dispute("Season", "Advent", "522bb79455449d881b004d27");

            //Assert
            Assert.AreEqual(1, myDispute.getReplacementValues().Count);
        }

        [TestMethod]
        public void TestDisputeConstructor_DictionaryOfReplacementValuesIsProperlyConstructed()
        {
            //Arrange
            Dispute myDispute;

            //Act
            myDispute = new Dispute("Season", "advent", "522bb79455449d881b004d27");

            //Assert
            Assert.AreEqual(new ReplacementValue("advent", "522bb79455449d881b004d27"), myDispute.getReplacementValues()[0]);
        }

        /*
         * Tests for the method AddUserReplacementvalue()
         */

        [TestMethod]
        [ExpectedException(typeof(ArgumentException), "In Class Dispute, AddNewReplacementValue().  String arguement replacementValue cannot be null, empty, or white space.")]
        public void TestClassDispute_MethodAddUserReplacementvalue_ArgumentReplacementValueIsNull_ThrowsArgumentException()
        {
            //Arrange
            Dispute myDispute = new Dispute("Season", "Advent", "522bb79455449d881b004d27");

            //Act
            myDispute.AddUserReplacementvalue(null, "522bb79455449d881b004d27");
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException), "In Class Dispute, AddNewReplacementValue().  String arguement replacementValue cannot be null, empty, or white space.")]
        public void TestClassDispute_MethodAddUserReplacementvalue_ArgumentReplacementValueIsEmptyString_ThrowsArgumentException()
        {
            //Arrange
            Dispute myDispute = new Dispute("Season", "Advent", "522bb79455449d881b004d27");

            //Act
            myDispute.AddUserReplacementvalue("", "522bb79455449d881b004d27");
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException), "In Class Dispute, AddNewReplacementValue().  String arguement replacementValue cannot be null, empty, or white space.")]
        public void TestClassDispute_MethodAddUserReplacementvalue_ArgumentReplacementValueIsWhiteSpace_ThrowsArgumentException()
        {
            //Arrange
            Dispute myDispute = new Dispute("Season", "Advent", "522bb79455449d881b004d27");

            //Act
            myDispute.AddUserReplacementvalue("  ", "522bb79455449d881b004d27");
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException), "In Class Dispute, AddNewReplacementValue().  String arguement institutionId cannot be null, empty, or white space.")]
        public void TestClassDispute_MethodAddUserReplacementvalue_ArgumentInstitutionIdIsNull_ThrowsArgumentException()
        {
            //Arrange
            Dispute myDispute = new Dispute("Season", "Advent", "522bb79455449d881b004d27");

            //Act
            myDispute.AddUserReplacementvalue("Lent", null);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException), "In Class Dispute, AddNewReplacementValue().  String arguement institutionId cannot be null, empty, or white space.")]
        public void TestClassDispute_MethodAddUserReplacementvalue_ArgumentInstitutionIdIsEmptyString_ThrowsArgumentException()
        {
            //Arrange
            Dispute myDispute = new Dispute("Season", "Advent", "522bb79455449d881b004d27");

            //Act
            myDispute.AddUserReplacementvalue("Lent", "");
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException), "In Class Dispute, AddNewReplacementValue().  String arguement institutionId cannot be null, empty, or white space.")]
        public void TestClassDispute_MethodAddUserReplacementvalue_ArgumentInstitutionIdIsWhiteSpace_ThrowsArgumentException()
        {
            //Arrange
            Dispute myDispute = new Dispute("Season", "Advent", "522bb79455449d881b004d27");

            //Act
            myDispute.AddUserReplacementvalue("Lent", "  ");
        }

        [TestMethod]
        public void TestClassDispute_MethodAddUserReplacementvalue_ValueAlreadyExistsJustAddTheUser()
        {
            //Arrange
            Dispute myDispute = new Dispute("Season", "Advent", "522bb79455449d881b004d27");
            List<ReplacementValue> expectedValue = new List<ReplacementValue>() { 
                new ReplacementValue("Advent", "522bb79455449d881b004d27")
            };
            expectedValue[0].AddInsitutionId("9999979455449d881b004d27");

            //Act
            myDispute.AddUserReplacementvalue("Advent", "9999979455449d881b004d27");

            //Assert
            CollectionAssert.AreEqual(expectedValue.AsReadOnly(), myDispute.getReplacementValues());
        }

        [TestMethod]
        public void TestClassDispute_MethodAddUserReplacementvalue_ValueDoesNotExistAddNewReplacementValue()
        {
            //Arrange
            Dispute myDispute = new Dispute("Season", "Advent", "522bb79455449d881b004d27");
            List<ReplacementValue> expectedValue = new List<ReplacementValue>() { 
                new ReplacementValue("Advent", "522bb79455449d881b004d27"),
                new ReplacementValue("Lent", "522bb79455449d881b004d27")
            };

            //Act
            myDispute.AddUserReplacementvalue("Lent", "522bb79455449d881b004d27");

            //Assert
            CollectionAssert.AreEqual(expectedValue.AsReadOnly(), myDispute.getReplacementValues());
        }


        /*
         * Tests for the method UpdateUserReplacementValue()
         */

        [TestMethod]
        [ExpectedException(typeof(ArgumentException), "In Dispute, AddNewReplacementvalue_RemoveOld().  NewReplacementValue argument must have text.")]
        public void TestClassDispute_MethodUpdateUserReplacementValue_ArgumentNewReplacementValueIsNull_ThrowsArgumentException()
        {
            //Arrange
            Dispute myDispute = new Dispute("Season", "Advent", "522bb79455449d881b004d27");

            //Act
            myDispute.UpdateUserReplacementValue(null, "Advent", "522bb79455449d881b004d27");
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException), "In Dispute, AddNewReplacementvalue_RemoveOld().  NewReplacementValue argument must have text.")]
        public void TestClassDispute_MethodUpdateUserReplacementValue_ArgumentNewReplacementValueIsEmptyString_ThrowsArgumentException()
        {
            //Arrange
            Dispute myDispute = new Dispute("Season", "Advent", "522bb79455449d881b004d27");

            //Act
            myDispute.UpdateUserReplacementValue("", "Advent", "522bb79455449d881b004d27");
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException), "In Dispute, AddNewReplacementvalue_RemoveOld().  NewReplacementValue argument must have text.")]
        public void TestClassDispute_MethodUpdateUserReplacementValue_ArgumentNewReplacementValueIsWhiteSpace_ThrowsArgumentException()
        {
            //Arrange
            Dispute myDispute = new Dispute("Season", "Advent", "522bb79455449d881b004d27");

            //Act
            myDispute.UpdateUserReplacementValue("  ", "Advent", "522bb79455449d881b004d27");
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException), "In Dispute, AddNewReplacementvalue_RemoveOld().  OldReplacementValue argument must have text.")]
        public void TestClassDispute_MethodUpdateUserReplacementValue_ArgumentOldReplacementValueIsNull_ThrowsArgumentException()
        {
            //Arrange
            Dispute myDispute = new Dispute("Season", "Advent", "522bb79455449d881b004d27");

            //Act
            myDispute.UpdateUserReplacementValue("Lent", null, "522bb79455449d881b004d27");
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException), "In Dispute, AddNewReplacementvalue_RemoveOld().  OldReplacementValue argument must have text.")]
        public void TestClassDispute_MethodUpdateUserReplacementValue_ArgumentOldReplacementValueIsEmptyString_ThrowsArgumentException()
        {
            //Arrange
            Dispute myDispute = new Dispute("Season", "Advent", "522bb79455449d881b004d27");

            //Act
            myDispute.UpdateUserReplacementValue("Lent", "", "522bb79455449d881b004d27");
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException), "In Dispute, AddNewReplacementvalue_RemoveOld().  OldReplacementValue argument must have text.")]
        public void TestClassDispute_MethodUpdateUserReplacementValue_ArgumentOldReplacementValueIsWhiteSpace_ThrowsArgumentException()
        {
            //Arrange
            Dispute myDispute = new Dispute("Season", "Advent", "522bb79455449d881b004d27");

            //Act
            myDispute.UpdateUserReplacementValue("Lent", "  ", "522bb79455449d881b004d27");
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException), "In Dispute, AddNewReplacementvalue_RemoveOld().  InstitutionId argument must have text.")]
        public void TestClassDispute_MethodUpdateUserReplacementValue_ArgumentInstitutionIdIsNull_ThrowsArgumentException()
        {
            //Arrange
            Dispute myDispute = new Dispute("Season", "Advent", "522bb79455449d881b004d27");

            //Act
            myDispute.UpdateUserReplacementValue("Lent", "Advent", null);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException), "In Dispute, AddNewReplacementvalue_RemoveOld().  InstitutionId argument must have text.")]
        public void TestClassDispute_MethodUpdateUserReplacementValue_ArgumentInstitutionIdIsEmptyString_ThrowsArgumentException()
        {
            //Arrange
            Dispute myDispute = new Dispute("Season", "Advent", "522bb79455449d881b004d27");

            //Act
            myDispute.UpdateUserReplacementValue("Lent", "Advent", "");
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException), "In Dispute, AddNewReplacementvalue_RemoveOld().  InstitutionId argument must have text.")]
        public void TestClassDispute_MethodUpdateUserReplacementValue_ArgumentInstitutionIdIsWhiteSpace_ThrowsArgumentException()
        {
            //Arrange
            Dispute myDispute = new Dispute("Season", "Advent", "522bb79455449d881b004d27");

            //Act
            myDispute.UpdateUserReplacementValue("Lent", "Advent", "  ");
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException), "In Dispute, AddNewReplacementvalue_RemoveOld().  The argument oldReplacementValue does not exist.")]
        public void TestClassDispute_MethodUpdateUserReplacementValue_ArgumentOldReplacementValueDoesNotExist_ThrowsArgumentException()
        {
            //Arrange
            Dispute myDispute = new Dispute("Season", "Advent", "522bb79455449d881b004d27");

            //Act
            myDispute.UpdateUserReplacementValue("Lent", "Easter", "522bb79455449d881b004d27");
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException), "In class ReplacementValue, RemoveInsitutionId(). Attempted to remove an institutionId (objectId) from a replacement value where that institutionId does not exist.")]
        public void TestClassDispute_MethodUpdateUserReplacementValue_ArgumentOldInsitutionIdDoesNotExist_ThrowsArgumentException()
        {
            //Arrange
            Dispute myDispute = new Dispute("Season", "Advent", "522bb79455449d881b004d27");

            //Act
            myDispute.UpdateUserReplacementValue("Lent", "Advent", "999bb79455449d881b004d27");
        }

        [TestMethod]
        public void TestClassDispute_MethodUpdateUserReplacementValue_UserReplacementValueDoesNotAlreadyExist()
        {
            //Arrange
            Dispute myDispute;
            List<ReplacementValue> expectedValue = new List<ReplacementValue>()
            {
                new ReplacementValue("advent", "522bb79455449d881b004d27"),
                new ReplacementValue("lent", "522bb79455449d881b004d27")
            };
            expectedValue[0].RemoveInstituionId("522bb79455449d881b004d27");

            //Act
            myDispute = new Dispute("Season", "Advent", "522bb79455449d881b004d27");
            myDispute.UpdateUserReplacementValue("Lent", "Advent", "522bb79455449d881b004d27");

            //Assert are equal
            CollectionAssert.AreEqual(expectedValue.AsReadOnly(), myDispute.getReplacementValues());
        }

        [TestMethod]
        public void TestClassDispute_MethodUpdateUserReplacementValue_UserReplacementValueAlreadyExists()
        {
            //Arrange
            Dispute myDispute = new Dispute("Season", "Advent", "522bb79455449d881b004d27");
            myDispute.AddUserReplacementvalue("Lent", "9999979455449d881b004d27");

            List<ReplacementValue> expectedValue = new List<ReplacementValue>()
            {
                new ReplacementValue("Advent", "522bb79455449d881b004d27"),
                new ReplacementValue("Lent", "9999979455449d881b004d27")
            };
            expectedValue[0].RemoveInstituionId("522bb79455449d881b004d27");
            expectedValue[1].AddInsitutionId("522bb79455449d881b004d27");

            //Act
            myDispute.UpdateUserReplacementValue("Lent", "Advent", "522bb79455449d881b004d27");

            //Assert are equal
            CollectionAssert.AreEqual(expectedValue.AsReadOnly(), myDispute.getReplacementValues());
        }
    }
}
