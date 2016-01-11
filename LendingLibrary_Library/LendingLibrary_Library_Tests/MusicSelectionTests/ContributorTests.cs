using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using LendingLibrary_Library.MusicSelection;
using LendingLibrary_Library.Utility;
namespace LendingLibrary_Library_Tests.MusicSelectionTests
{
    [TestClass]
    public class ContributorTests
    {
        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException), "In class contributor, constructor.  The String argument role cannot be null.")]
        public void Contributor_Constructor_ArgumentRoleIsNull_ThrowsArgumentNullException()
        {
            //Arrange
            Contributor myContributor;
            Name myName = new Name("Bob", "Michael", "Anderson");

            //Act
            myContributor = new Contributor(myName, null);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException), "In class contributor, constructor.  The String argument role cannot be an empty string.")]
        public void Contributor_Constructor_ArgumentRoleIsEmptyString_ThrowsArgumentException()
        {
            //Arrange
            Contributor myContributor;
            Name myName = new Name("Bob", "Michael", "Anderson");

            //Act
            myContributor = new Contributor(myName, "");
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException), "In class contributor, constructor.  The String argument role cannot be white space.")]
        public void Contributor_Constructor_ArgumentRoleIsWhiteSpace_ThrowsArgumentException()
        {
            //Arrange
            Contributor myContributor;
            Name myName = new Name("Bob", "Michael", "Anderson");

            //Act
            myContributor = new Contributor(myName, "  ");
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException), "In class Contribtor, constructor.  Boolean arguments unknown and anonymous cannot both be true or both be false.")]
        public void Contributor_Constructor_unknownAndAnonymousArgumentsAreEqual_ThrowsArgumentException()
        {
            //Arrange
            Contributor myContributor;

            //Act
            myContributor = new Contributor(unknown: false, anonymous: false);
        }

        [TestMethod]
        public void Contributor_MethodGetFullName()
        {
            //Arrange
            Contributor myContributor;
            Name myName = new Name("Bob", "Michael", "Anderson");

            //Act
            myContributor = new Contributor(myName, "Arranger");

            //Assert
            Assert.AreEqual("Bob Michael Anderson", myContributor.getFullName());
        }

        [TestMethod]
        public void Contributor_MethodGetFullName_LowerCase()
        {
            //Arrange
            Contributor myContributor;
            Name myName = new Name("Bob", "Michael", "Anderson");

            //Act
            myContributor = new Contributor(myName, "Arranger");

            //Assert
            Assert.AreEqual("bob michael anderson", myContributor.getFullName_LowerCase());
        }

        [TestMethod]
        public void Contributor_Constructor2_ArgumentUnknownIsTrue_MethodGetFullNameReturnsUnknown()
        {
            //Arrange
            Contributor myContributor;

            //Act
            myContributor = new Contributor(unknown: true, anonymous: false);

            //Assert
            Assert.AreEqual("unknown", myContributor.getFullName());
        }

        [TestMethod]
        public void Contributor_Constructor2_ArgumentAnonymousIsTrue_MethodGetFullNameReturnsAnonymous()
        {
            //Arrange
            Contributor myContributor;

            //Act
            myContributor = new Contributor(unknown: false, anonymous: true);

            //Assert
            Assert.AreEqual("anonymous", myContributor.getFullName());
        }

        [TestMethod]
        public void Contributor_Constructor2_ArgumentUnknownIsTrue_RoleSetAsComposer()
        {
            //Arrange
            Contributor myContributor;

            //Act
            myContributor = new Contributor(unknown: true, anonymous: false);

            //Assert
            Assert.AreEqual("Composer", myContributor.Role);
        }

        [TestMethod]
        public void Contributor_Constructor2_ArgumentAnonymousIsTrue_RoleSetAsComposer()
        {
            //Arrange
            Contributor myContributor;

            //Act
            myContributor = new Contributor(unknown: false, anonymous: true);

            //Assert
            Assert.AreEqual("Composer", myContributor.Role);
        }

        [TestMethod]
        public void Contributor_MethodGetHashCodeEqualOnTwoEqualInstances()
        {
            //Arrange
            Contributor myContributor;
            Contributor myContributor2;
            Name myName = new Name("John", "David", "Andrews");
            Name myName2 = new Name("John", "David", "Andrews");

            //Act
            myContributor = new Contributor(myName, "Composer");
            myContributor2 = new Contributor(myName2, "Composer");

            //Assert
            Assert.AreEqual(myContributor2.GetHashCode(), myContributor.GetHashCode());
        }

        [TestMethod]
        public void Contributor_MethodGetHashCodeNotEqualOnTwoDifferentInstances()
        {
            //Arrange
            Contributor myContributor;
            Contributor myContributor2;
            Name myName = new Name("John", "David", "Andrews");
            Name myName2 = new Name("John", "David", "Montgomery");

            //Act
            myContributor = new Contributor(myName, "Composer");
            myContributor2 = new Contributor(myName2, "Composer");

            //Assert
            Assert.AreNotEqual(myContributor2.GetHashCode(), myContributor.GetHashCode());
        }

        [TestMethod]
        public void Contributor_MethodEquals()
        {
            //Arrange
            Contributor myContributor;
            Contributor myContributor2;
            Name myName = new Name("John", "David", "Andrews");
            Name myName2 = new Name("John", "David", "Andrews");

            //Act
            myContributor = new Contributor(myName, "Composer");
            myContributor2 = new Contributor(myName2, "Composer");

            //Assert
            Assert.AreEqual(true, myContributor.Equals(myContributor2));
        }
    }
}
