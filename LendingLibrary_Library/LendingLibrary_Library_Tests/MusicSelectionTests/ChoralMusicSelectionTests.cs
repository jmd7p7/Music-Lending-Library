using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using LendingLibrary_Library.MusicSelection;
using LendingLibrary_Library.Utility;
using System.Collections.Generic;

namespace LendingLibrary_Library_Tests.MusicSelectionTests
{
    [TestClass]
    public class ChoralMusicSelectionTests
    {
        [TestMethod]
        public void ChoralMusicSelection_Constructor_IsSacredSetCorrectly()
        {
            //Arrange
            Contributor composer = new Contributor(new Name("David", "", "Hass"), "Composer");
            ChoralMusicSelection myChoralMusicSelection;

            //Act
            myChoralMusicSelection  = new ChoralMusicSelection("507f191e810c19729de860ea", "Blest Are They", composer, true);

            //Assert
            Assert.AreEqual(true, myChoralMusicSelection.IsSacred);
        }

        [TestMethod]
        public void ChoralMusicSelection_MethodSetVoicing()
        {
            //Arrange
            Contributor composer = new Contributor(new Name("David", "", "Hass"), "Composer");
            ChoralMusicSelection myChoralMusicSelection 
                = new ChoralMusicSelection("507f191e810c19729de860ea", "Blest Are They", composer, true);

            //Act
            myChoralMusicSelection.setVoicing("SSA");

            //Assert
            Assert.AreEqual("SSA", myChoralMusicSelection.Voicing);
        }

        [TestMethod]
        public void ChoralMusicSelection_MethodSetVoicing_LowerCase()
        {
            //Arrange
            Contributor composer = new Contributor(new Name("David", "", "Hass"), "Composer");
            ChoralMusicSelection myChoralMusicSelection
                = new ChoralMusicSelection("507f191e810c19729de860ea", "Blest Are They", composer, true);

            //Act
            myChoralMusicSelection.setVoicing("SSA");

            //Assert
            Assert.AreEqual("ssa", myChoralMusicSelection.Voicing_LowerCase);
        }

        [TestMethod]
        public void ChoralMusicSelection_MethodSetAccompaniment()
        {
            //Arrange
            Contributor composer = new Contributor(new Name("David", "", "Hass"), "Composer");
            ChoralMusicSelection myChoralMusicSelection
                = new ChoralMusicSelection("507f191e810c19729de860ea", "Blest Are They", composer, true);

            //Act
            myChoralMusicSelection.setAccompaniment(" Organ and Brass ");

            //Assert
            Assert.AreEqual("Organ and Brass", myChoralMusicSelection.Accompaniment);
        }

        [TestMethod]
        public void ChoralMusicSelection_MethodSetAccompaniment_LowerCase()
        {
            //Arrange
            Contributor composer = new Contributor(new Name("David", "", "Hass"), "Composer");
            ChoralMusicSelection myChoralMusicSelection
                = new ChoralMusicSelection("507f191e810c19729de860ea", "Blest Are They", composer, true);

            //Act
            myChoralMusicSelection.setAccompaniment(" Organ and Brass ");

            //Assert
            Assert.AreEqual("organ and brass", myChoralMusicSelection.Accompaniment_LowerCase);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException), "In class ChoralMusicSelection, method setInstrumentParts().  Argument cannot be null.")]
        public void ChoralMusicSelection_MethodSetInstrumentParts_ArgumentIsNull_ThrowsArgumentNullException()
        {
            //Arrange
            Contributor composer = new Contributor(new Name("David", "", "Hass"), "Composer");
            ChoralMusicSelection myChoralMusicSelection
                = new ChoralMusicSelection("507f191e810c19729de860ea", "Blest Are They", composer, true);

            //Act
            myChoralMusicSelection.setInstrumentParts(null);
        }

        [TestMethod]
        public void ChoralMusicSelection_MethodSetInstrumentParts()
        {
            //Arrange
            Contributor composer = new Contributor(new Name("David", "", "Hass"), "Composer");
            ChoralMusicSelection myChoralMusicSelection
                = new ChoralMusicSelection("507f191e810c19729de860ea", "Blest Are They", composer, true);
            List<ChoralInstrumentPart> expectedInstrumentParts =
                new List<ChoralInstrumentPart>() {
                    new ChoralInstrumentPart("Trombone", 2, true),
                    new ChoralInstrumentPart("Flute", 3, true)
                };

            //Act
            List<ChoralInstrumentPart> instrumentParts =
                new List<ChoralInstrumentPart>() {
                    new ChoralInstrumentPart("Trombone", 2, true),
                    new ChoralInstrumentPart("Flute", 3, true)
                };
            myChoralMusicSelection.setInstrumentParts(instrumentParts);

            //Assert
            CollectionAssert.AreEqual(expectedInstrumentParts, myChoralMusicSelection.getInstrumentParts());
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException), "In class ChoralMusicSelection, method addInstrumentPart().  Argument cannot be null.")]
        public void ChoralMusicSelection_MethodAddInstrumentPart_ArgumentIsNull_ThrowsArgumentNullException()
        {
            //Arrange
            Contributor composer = new Contributor(new Name("David", "", "Hass"), "Composer");
            ChoralMusicSelection myChoralMusicSelection
                = new ChoralMusicSelection("507f191e810c19729de860ea", "Blest Are They", composer, true);

            //Act
            myChoralMusicSelection.addInstrumentPart(null);
        }

        [TestMethod]
        public void ChoralMusicSelection_MethodAddInstrumentPart_AttemptToAddItemAlreadyInTheList_DoesNotChangeTheList()
        {
            //Arrange
            Contributor composer = new Contributor(new Name("David", "", "Hass"), "Composer");
            ChoralMusicSelection myChoralMusicSelection
                = new ChoralMusicSelection("507f191e810c19729de860ea", "Blest Are They", composer, true);
            ChoralInstrumentPart myInstrumentPart = new ChoralInstrumentPart("Flute", 2, false);
            myChoralMusicSelection.addInstrumentPart(myInstrumentPart);
            List<ChoralInstrumentPart> expectedValue = new List<ChoralInstrumentPart>() { myInstrumentPart };

            //Act
            myChoralMusicSelection.addInstrumentPart(myInstrumentPart);

            //Assert
            CollectionAssert.AreEqual(expectedValue, myChoralMusicSelection.getInstrumentParts());
        }

        [TestMethod]
        public void ChoralMusicSelection_MethodAddInstrumentPart()
        {
            //Arrange
            Contributor composer = new Contributor(new Name("David", "", "Hass"), "Composer");
            ChoralMusicSelection myChoralMusicSelection
                = new ChoralMusicSelection("507f191e810c19729de860ea", "Blest Are They", composer, true);
            ChoralInstrumentPart myInstrumentPart = new ChoralInstrumentPart("Flute", 2, false);
            ChoralInstrumentPart myInstrumentPart2 = new ChoralInstrumentPart("Oboe", 2, false);
            List<ChoralInstrumentPart> expectedValue = new List<ChoralInstrumentPart>() { myInstrumentPart, myInstrumentPart2 };

            //Act
            myChoralMusicSelection.addInstrumentPart(myInstrumentPart);
            myChoralMusicSelection.addInstrumentPart(myInstrumentPart2);

            //Assert
            CollectionAssert.AreEqual(expectedValue, myChoralMusicSelection.getInstrumentParts());
        }


        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException), "In class ChoralMusicSelection, method removeInstrumentPart().  Argument cannot be null.")]
        public void ChoralMusicSelection_MethodRemoveInstrumentPart_ArgumentIsNull_ThrowsArgumentNullException()
        {
            //Arrange
            Contributor composer = new Contributor(new Name("David", "", "Hass"), "Composer");
            ChoralMusicSelection myChoralMusicSelection
                = new ChoralMusicSelection("507f191e810c19729de860ea", "Blest Are They", composer, true);

            //Act
            myChoralMusicSelection.removeInstrumentPart(null);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException), "In class ChoralMusicSelection, method removeInstrumentPart(). Unable to remove instrument part that does not exist in the list.")]
        public void ChoralMusicSelection_MethodRemoveInstrumentPart_ArgumentIsNotInTheList_ThrowsArgumentException()
        {
            //Arrange
            Contributor composer = new Contributor(new Name("David", "", "Hass"), "Composer");
            ChoralMusicSelection myChoralMusicSelection
                = new ChoralMusicSelection("507f191e810c19729de860ea", "Blest Are They", composer, true);
            ChoralInstrumentPart myInstrumentPart = new ChoralInstrumentPart("Flute", 2, false);

            //Act
            myChoralMusicSelection.removeInstrumentPart(myInstrumentPart);
        }

        [TestMethod]
        public void ChoralMusicSelection_MethodRemoveInstrumentPart()
        {
            //Arrange
            Contributor composer = new Contributor(new Name("David", "", "Hass"), "Composer");
            ChoralMusicSelection myChoralMusicSelection
                = new ChoralMusicSelection("507f191e810c19729de860ea", "Blest Are They", composer, true);
            ChoralInstrumentPart myInstrumentPart1 = new ChoralInstrumentPart("Flute", 2, false);
            ChoralInstrumentPart myInstrumentPart2 = new ChoralInstrumentPart("Oboe", 2, false);
            ChoralInstrumentPart myInstrumentPart3 = new ChoralInstrumentPart("Bassoon", 2, false);
            List<ChoralInstrumentPart> expectedValue = new List<ChoralInstrumentPart>() { myInstrumentPart1, myInstrumentPart3 };

            //Act
            myChoralMusicSelection.addInstrumentPart(myInstrumentPart1);
            myChoralMusicSelection.addInstrumentPart(myInstrumentPart2);
            myChoralMusicSelection.addInstrumentPart(myInstrumentPart3);

            myChoralMusicSelection.removeInstrumentPart(myInstrumentPart2);

            //Assert
            CollectionAssert.AreEqual(expectedValue, myChoralMusicSelection.getInstrumentParts());
        }
    }
}
