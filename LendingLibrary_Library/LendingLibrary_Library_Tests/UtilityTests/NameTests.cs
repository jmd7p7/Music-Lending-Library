using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using LendingLibrary_Library.Utility;
namespace LendingLibrary_Library_Tests.UtilityTests
{
    [TestClass]
    public class NameTests
    {
        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException), "In class Name, constructor.  String argument lastName cannot be null.")]
        public void Name_Constructor_StringArgumentLastNameIsNull_ThrowsArgumentNullException()
        {
            //Arrange
            Name myName;

            //Act
            myName = new Name(firstName: "Jon", middleName: "M", lastName: null, prefix: "Mr", suffix: "Jr");
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException), "In class Name, constructor.  String argument lastName cannot be empty.")]
        public void Name_Constructor_StringArgumentLastNameIsEmpty_ThrowsArgumentException()
        {
            //Arrange
            Name myName;

            //Act
            myName = new Name(firstName: "Jon", middleName: "M", lastName: "", prefix: "Mr", suffix: "Jr");
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException), "In class Name, constructor.  String argument lastName cannot be white space.")]
        public void Name_Constructor_StringArgumentLastNameIsWhiteSpace_ThrowsArgumentException()
        {
            //Arrange
            Name myName;

            //Act
            myName = new Name(firstName: "Jon", middleName: "M", lastName: "  ", prefix: "Mr", suffix: "Jr");
        }

        [TestMethod]
        public void Name_Constructor_LastNameCorrectlyFormatted()
        {
            //Arrange
            Name myName;

            //Act
            myName = new Name(firstName: null, middleName: "M", lastName: " Johnson  ", prefix: "Mr", suffix: "Jr");

            //Assert
            Assert.AreEqual("Johnson", myName.LastName);
        }

        [TestMethod]
        public void Name_Constructor_LastName_LowerCaseCorrectlyFormatted()
        {
            //Arrange
            Name myName;

            //Act
            myName = new Name(firstName: null, middleName: "M", lastName: " Johnson  ", prefix: "Mr", suffix: "Jr");

            //Assert
            Assert.AreEqual("johnson", myName.LastName_LowerCase);
        }

        [TestMethod]
        public void Name_Constructor_StringArgumentFirstNameIsNull_FieldFirstNameSetToEmptyString()
        {
            //Arrange
            Name myName;

            //Act
            myName = new Name(firstName: null, middleName: "M", lastName: "Johnson", prefix: "Mr", suffix: "Jr");

            //Assert
            Assert.AreEqual("", myName.FirstName);
        }

        [TestMethod]
        public void Name_Constructor_StringArgumentFirstNameIsNull_FieldFirstName_LowerCaseSetToEmptyString()
        {
            //Arrange
            Name myName;

            //Act
            myName = new Name(firstName: null, middleName: "M", lastName: "Johnson", prefix: "Mr", suffix: "Jr");

            //Assert
            Assert.AreEqual("", myName.FirtName_LowerCase);
        }

        [TestMethod]
        public void Name_Constructor_StringArgumentFirstNameIsEmpty_FieldFirstNameSetToEmptyString()
        {
            //Arrange
            Name myName;

            //Act
            myName = new Name(firstName: "", middleName: "M", lastName: "Johnson", prefix: "Mr", suffix: "Jr");

            //Assert
            Assert.AreEqual("", myName.FirstName);
        }

        [TestMethod]
        public void Name_Constructor_StringArgumentFirstNameIsEmpty_FieldFirstName_LowerCaseSetToEmptyString()
        {
            //Arrange
            Name myName;

            //Act
            myName = new Name(firstName: "", middleName: "M", lastName: "Johnson", prefix: "Mr", suffix: "Jr");

            //Assert
            Assert.AreEqual("", myName.FirtName_LowerCase);
        }

        [TestMethod]
        public void Name_Constructor_StringArgumentFirstNameIsWhiteSpace_FieldFirstNameSetToEmptyString()
        {
            //Arrange
            Name myName;

            //Act
            myName = new Name(firstName: "   ", middleName: "M", lastName: "Johnson", prefix: "Mr", suffix: "Jr");

            //Assert
            Assert.AreEqual("", myName.FirstName);
        }

        [TestMethod]
        public void Name_Constructor_StringArgumentFirstNameIsWhiteSpace_FieldFirstName_LowerCaseSetToEmptyString()
        {
            //Arrange
            Name myName;

            //Act
            myName = new Name(firstName: "   ", middleName: "M", lastName: "Johnson", prefix: "Mr", suffix: "Jr");

            //Assert
            Assert.AreEqual("", myName.FirtName_LowerCase);
        }

        [TestMethod]
        public void Name_Constructor_FieldFirstNameCorrectlyFormatted()
        {
            //Arrange
            Name myName;

            //Act
            myName = new Name(firstName: " David  ", middleName: "M", lastName: "Johnson", prefix: "Mr", suffix: "Jr");

            //Assert
            Assert.AreEqual("David", myName.FirstName);
        }

        [TestMethod]
        public void Name_Constructor_FieldFirstName_LowerCaseCorrectlyFormatted()
        {
            //Arrange
            Name myName;

            //Act
            myName = new Name(firstName: " David  ", middleName: "M", lastName: "Johnson", prefix: "Mr", suffix: "Jr");

            //Assert
            Assert.AreEqual("david", myName.FirtName_LowerCase);
        }

        [TestMethod]
        public void Name_Constructor_StringArgumentMiddleNameIsNull_FieldMiddleNameSetToEmptyString()
        {
            //Arrange
            Name myName;

            //Act
            myName = new Name(firstName: "John", middleName: null, lastName: "Johnson", prefix: "Mr", suffix: "Jr");

            //Assert
            Assert.AreEqual("", myName.MiddleName);
        }

        [TestMethod]
        public void Name_Constructor_StringArgumentMiddleNameIsNull_FieldMiddleName_LowerCaseSetToEmptyString()
        {
            //Arrange
            Name myName;

            //Act
            myName = new Name(firstName: "John", middleName: null, lastName: "Johnson", prefix: "Mr", suffix: "Jr");

            //Assert
            Assert.AreEqual("", myName.MiddleName_LowerCase);
        }

        [TestMethod]
        public void Name_Constructor_StringArgumentMiddleNameIsEmpty_FieldMiddleNameSetToEmptyString()
        {
            //Arrange
            Name myName;

            //Act
            myName = new Name(firstName: "Jerry", middleName: "", lastName: "Johnson", prefix: "Mr", suffix: "Jr");

            //Assert
            Assert.AreEqual("", myName.MiddleName);
        }

        [TestMethod]
        public void Name_Constructor_StringArgumentMiddleNameIsEmpty_FieldMiddleName_LowerCaseSetToEmptyString()
        {
            //Arrange
            Name myName;

            //Act
            myName = new Name(firstName: "Jerry", middleName: "", lastName: "Johnson", prefix: "Mr", suffix: "Jr");

            //Assert
            Assert.AreEqual("", myName.MiddleName_LowerCase);
        }

        [TestMethod]
        public void Name_Constructor_StringArgumentMiddleNameIsWhiteSpace_FieldMiddleNameSetToEmptyString()
        {
            //Arrange
            Name myName;

            //Act
            myName = new Name(firstName: "Jerry", middleName: "  ", lastName: "Johnson", prefix: "Mr", suffix: "Jr");

            //Assert
            Assert.AreEqual("", myName.MiddleName);
        }

        [TestMethod]
        public void Name_Constructor_StringArgumentMiddleNameIsWhiteSpace_FieldMiddleName_LowerCaseSetToEmptyString()
        {
            //Arrange
            Name myName;

            //Act
            myName = new Name(firstName: "Jerry", middleName: "  ", lastName: "Johnson", prefix: "Mr", suffix: "Jr");

            //Assert
            Assert.AreEqual("", myName.MiddleName_LowerCase);
        }

        [TestMethod]
        public void Name_Constructor_FieldMiddleNameCorrectlyFormatted()
        {
            //Arrange
            Name myName;

            //Act
            myName = new Name(firstName: " David  ", middleName: "   Mark  ", lastName: "Johnson", prefix: "Mr", suffix: "Jr");

            //Assert
            Assert.AreEqual("Mark", myName.MiddleName);
        }

        [TestMethod]
        public void Name_Constructor_FieldMiddleName_LowerCaseCorrectlyFormatted()
        {
            //Arrange
            Name myName;

            //Act
            myName = new Name(firstName: " David  ", middleName: "   Mark  ", lastName: "Johnson", prefix: "Mr", suffix: "Jr");

            //Assert
            Assert.AreEqual("mark", myName.MiddleName_LowerCase);
        }

        [TestMethod]
        public void Name_Constructor_StringArgumentPrefixIsNull_FieldPrefixSetToEmptyString()
        {
            //Arrange
            Name myName;

            //Act
            myName = new Name(firstName: "John", middleName: "David", lastName: "Johnson", prefix: null, suffix: "Jr");

            //Assert
            Assert.AreEqual("", myName.Prefix);
        }

        [TestMethod]
        public void Name_Constructor_StringArgumentPrefixIsNull_FieldPrefix_LowerCaseSetToEmptyString()
        {
            //Arrange
            Name myName;

            //Act
            myName = new Name(firstName: "John", middleName: "David", lastName: "Johnson", prefix: null, suffix: "Jr");

            //Assert
            Assert.AreEqual("", myName.Prefix_LowerCase);
        }

        [TestMethod]
        public void Name_Constructor_StringArgumentPrefixIsEmpty_FieldPrefixSetToEmptyString()
        {
            //Arrange
            Name myName;

            //Act
            myName = new Name(firstName: "Gerry", middleName: "", lastName: "Johnson", prefix: "", suffix: "Jr");

            //Assert
            Assert.AreEqual("", myName.Prefix);
        }

        [TestMethod]
        public void Name_Constructor_StringArgumentPrefixIsEmpty_FieldPrefix_LowerCaseSetToEmptyString()
        {
            //Arrange
            Name myName;

            //Act
            myName = new Name(firstName: "Gerry", middleName: "", lastName: "Johnson", prefix: "", suffix: "Jr");

            //Assert
            Assert.AreEqual("", myName.Prefix_LowerCase);
        }

        [TestMethod]
        public void Name_Constructor_StringArgumentPrefixIsWhiteSpace_FieldPrefixSetToEmptyString()
        {
            //Arrange
            Name myName;

            //Act
            myName = new Name(firstName: "Joe", middleName: "  ", lastName: "Johnson", prefix: "  ", suffix: "Jr");

            //Assert
            Assert.AreEqual("", myName.Prefix);
        }

        [TestMethod]
        public void Name_Constructor_StringArgumentPrefixIsWhiteSpace_FieldPrefix_LowerCaseSetToEmptyString()
        {
            //Arrange
            Name myName;

            //Act
            myName = new Name(firstName: "Joe", middleName: "  ", lastName: "Johnson", prefix: "  ", suffix: "Jr");

            //Assert
            Assert.AreEqual("", myName.Prefix_LowerCase);
        }

        [TestMethod]
        public void Name_Constructor_FieldPrefixCorrectlyFormatted()
        {
            //Arrange
            Name myName;

            //Act
            myName = new Name(firstName: " David  ", middleName: "   Mark  ", lastName: "Johnson", prefix: " Mr  ", suffix: "Jr");

            //Assert
            Assert.AreEqual("Mr", myName.Prefix);
        }

        [TestMethod]
        public void Name_Constructor_FieldPrefix_LowerCaseCorrectlyFormatted()
        {
            //Arrange
            Name myName;

            //Act
            myName = new Name(firstName: " David  ", middleName: "   Mark  ", lastName: "Johnson", prefix: " Mr  ", suffix: "Jr");

            //Assert
            Assert.AreEqual("mr", myName.Prefix_LowerCase);
        }

        [TestMethod]
        public void Name_Constructor_StringArgumentSuffixIsNull_FieldSuffixSetToEmptyString()
        {
            //Arrange
            Name myName;

            //Act
            myName = new Name(firstName: "John", middleName: "David", lastName: "Johnson", prefix: "Mr", suffix: null);

            //Assert
            Assert.AreEqual("", myName.Suffix);
        }

        [TestMethod]
        public void Name_Constructor_StringArgumentSuffixIsNull_FieldSuffix_LowerCaseSetToEmptyString()
        {
            //Arrange
            Name myName;

            //Act
            myName = new Name(firstName: "John", middleName: "David", lastName: "Johnson", prefix: "Mr", suffix: null);

            //Assert
            Assert.AreEqual("", myName.Suffix_LowerCase);
        }

        [TestMethod]
        public void Name_Constructor_StringArgumentSuffixIsEmpty_FieldSuffixSetToEmptyString()
        {
            //Arrange
            Name myName;

            //Act
            myName = new Name(firstName: "John", middleName: "David", lastName: "Johnson", prefix: "Mr", suffix: "");

            //Assert
            Assert.AreEqual("", myName.Suffix);
        }

        [TestMethod]
        public void Name_Constructor_StringArgumentSuffixIsEmpty_FieldSuffix_LowerCaseSetToEmptyString()
        {
            //Arrange
            Name myName;

            //Act
            myName = new Name(firstName: "John", middleName: "David", lastName: "Johnson", prefix: "Mr", suffix: "");

            //Assert
            Assert.AreEqual("", myName.Suffix_LowerCase);
        }

        [TestMethod]
        public void Name_Constructor_StringArgumentSuffixIsWhiteSpace_FieldSuffixSetToEmptyString()
        {
            //Arrange
            Name myName;

            //Act
            myName = new Name(firstName: "John", middleName: "David", lastName: "Johnson", prefix: "Mr", suffix: "  ");

            //Assert
            Assert.AreEqual("", myName.Suffix);
        }

        [TestMethod]
        public void Name_Constructor_StringArgumentSuffixIsWhiteSpace_FieldSuffix_LowerCaseSetToEmptyString()
        {
            //Arrange
            Name myName;

            //Act
            myName = new Name(firstName: "John", middleName: "David", lastName: "Johnson", prefix: "Mr", suffix: "  ");

            //Assert
            Assert.AreEqual("", myName.Suffix_LowerCase);
        }

        [TestMethod]
        public void Name_Constructor_FieldSuffixCorrectlyFormatted()
        {
            //Arrange
            Name myName;

            //Act
            myName = new Name(firstName: " David  ", middleName: "   Mark  ", lastName: "Johnson", prefix: " Mr  ", suffix: "  Jr  ");

            //Assert
            Assert.AreEqual("Jr", myName.Suffix);
        }

        [TestMethod]
        public void Name_Constructor_FieldSuffix_LowerCaseCorrectlyFormatted()
        {
            //Arrange
            Name myName;

            //Act
            myName = new Name(firstName: " David  ", middleName: "   Mark  ", lastName: "Johnson", prefix: " Mr  ", suffix: "  Jr  ");

            //Assert
            Assert.AreEqual("jr", myName.Suffix_LowerCase);
        }

        [TestMethod]
        public void Name_MethodGetFullName_AllParametersUsed()
        {
            //Arrange
            Name myName;

            //Act
            myName = new Name("David", "Michael", "Gibbons", "Mr", "Jr");

            //Assert
            Assert.AreEqual("Mr David Michael Gibbons Jr", myName.getFullName());
        }

        [TestMethod]
        public void Name_MethodGetFullName_LowerCase_AllParametersUsed()
        {
            //Arrange
            Name myName;

            //Act
            myName = new Name("David", "Michael", "Gibbons", "Mr", "Jr");

            //Assert
            Assert.AreEqual("mr david michael gibbons jr", myName.getFullName_LowerCase());
        }

        [TestMethod]
        public void Name_MethodGetFullName_SuffixAndPrefixNotUsed()
        {
            //Arrange
            Name myName;

            //Act
            myName = new Name("David", "Michael", "Gibbons", "", "");

            //Assert
            Assert.AreEqual("David Michael Gibbons", myName.getFullName());
        }

        [TestMethod]
        public void Name_MethodGetFullName_LowerCase_SuffixAndPrefixNotUsed()
        {
            //Arrange
            Name myName;

            //Act
            myName = new Name("David", "Michael", "Gibbons", "", "");

            //Assert
            Assert.AreEqual("david michael gibbons", myName.getFullName_LowerCase());
        }

        [TestMethod]
        public void Name_MethodGetFullName_PrefixNotUsed()
        {
            //Arrange
            Name myName;

            //Act
            myName = new Name("David", "Michael", "Gibbons", "", "Sr");

            //Assert
            Assert.AreEqual("David Michael Gibbons Sr", myName.getFullName());
        }

        [TestMethod]
        public void Name_MethodGetFullName_LowerCase_PrefixNotUsed()
        {
            //Arrange
            Name myName;

            //Act
            myName = new Name("David", "Michael", "Gibbons", "", "Sr");

            //Assert
            Assert.AreEqual("david michael gibbons sr", myName.getFullName_LowerCase());
        }

        [TestMethod]
        public void Name_MethodGetFullName_SuffixNotUsed()
        {
            //Arrange
            Name myName;

            //Act
            myName = new Name("David", "Michael", "Gibbons", "Dr", "");

            //Assert
            Assert.AreEqual("Dr David Michael Gibbons", myName.getFullName());
        }

        [TestMethod]
        public void Name_MethodGetFullName_LowerCase_SuffixNotUsed()
        {
            //Arrange
            Name myName;

            //Act
            myName = new Name("David", "Michael", "Gibbons", "Dr", "");

            //Assert
            Assert.AreEqual("dr david michael gibbons", myName.getFullName_LowerCase());
        }

        [TestMethod]
        public void Name_MethodGetFullName_MiddleNameNotUsed()
        {
            //Arrange
            Name myName;

            //Act
            myName = new Name("David", "", "Gibbons", "Dr", "Jr");

            //Assert
            Assert.AreEqual("Dr David Gibbons Jr", myName.getFullName());
        }

        [TestMethod]
        public void Name_MethodGetFullName_LowerCase_MiddleNameNotUsed()
        {
            //Arrange
            Name myName;

            //Act
            myName = new Name("David", "", "Gibbons", "Dr", "Jr");

            //Assert
            Assert.AreEqual("dr david gibbons jr", myName.getFullName_LowerCase());
        }

        [TestMethod]
        public void Name_MethodGetHashCode_LastNameOnly()
        {
            //Arrange
            Name myName;
            Name myName2;

            //Act
            myName = new Name("", "", "Gibbons");
            myName2 = new Name("", "", "Gibbons");

            //Assert
            Assert.AreEqual(myName.GetHashCode(), myName2.GetHashCode());
        }

        [TestMethod]
        public void Name_MethodGetHashCode_FirstMiddleLastPrefixSuffix()
        {
            //Arrange
            Name myName;
            Name myName2;

            //Act
            myName = new Name("John", "David", "Gibbons", "Mr", "Jr");
            myName2 = new Name("John", "David", "Gibbons", "Mr", "Jr");

            //Assert
            Assert.AreEqual(myName.GetHashCode(), myName2.GetHashCode());
        }

        [TestMethod]
        public void Name_MethodEquals()
        {
            //Arrange
            Name myName;
            Name myName2;

            //Act
            myName = new Name("John", "David", "Gibbons", "Mr", "Jr");
            myName2 = new Name("John", "David", "Gibbons", "Mr", "Jr");

            //Assert
            Assert.AreEqual(true, myName.Equals(myName2));
        }

    }
}
