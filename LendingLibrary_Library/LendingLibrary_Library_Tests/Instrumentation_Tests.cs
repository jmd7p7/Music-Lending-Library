using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using LendingLibrary_Library.MusicSelection;

namespace LendingLibrary_Library_Tests
{
    [TestClass]
    public class Instrumentation_Tests
    {
        [TestMethod]
        [ExpectedException(typeof(ArgumentException), "In class Instrumentation, constructor.  Argument instrumentationName cannot be null, empty string, or white space.")]
        public void TestInstrumentationConstructor_ArgumentInstrumentationNameIsNull_ThrowsArgumentException()
        {
            //Arrange
            Instrumentation myInstrumentation;

            //Act
            myInstrumentation = new Instrumentation(null, true);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException), "In class Instrumentation, constructor.  Argument instrumentationName cannot be null, empty string, or white space.")]
        public void TestInstrumentationConstructor_ArgumentInstrumentationNameIsEmptyString_ThrowsArgumentException()
        {
            //Arrange
            Instrumentation myInstrumentation;

            //Act
            myInstrumentation = new Instrumentation("", true);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException), "In class Instrumentation, constructor.  Argument instrumentationName cannot be null, empty string, or white space.")]
        public void TestInstrumentationConstructor_ArgumentInstrumentationNameIsWhiteSpace_ThrowsArgumentException()
        {
            //Arrange
            Instrumentation myInstrumentation;

            //Act
            myInstrumentation = new Instrumentation("  ", true);
        }

        [TestMethod]
        public void TestInstrumentationConstructor_ArgumentCreatedByAdministratorIsTrueNumberOfTimesUsedShouldBeSetToZero()
        {
            //Arrange
            Instrumentation myInstrumentation;

            //Act
            myInstrumentation = new Instrumentation("Full Orchestra", true);

            //Assert
            Assert.AreEqual(0, myInstrumentation.NumberOfTimesUsed);
        }

        [TestMethod]
        public void TestInstrumentationConstructor_ArgumentCreatedByAdministratorIsFalseNumberOfTimesUsedShouldBeSetToOne()
        {
            //Arrange
            Instrumentation myInstrumentation;

            //Act
            myInstrumentation = new Instrumentation("Full Orchestra", false);

            //Assert
            Assert.AreEqual(1, myInstrumentation.NumberOfTimesUsed);
        }

        [TestMethod]
        public void TestInstrumentationConstructor_FieldInstrumentationNameIsStrippedOfWhiteSpace()
        {
            //Arrange
            Instrumentation myInstrumentation;

            //Act
            myInstrumentation = new Instrumentation("  Full Orchestra  ", false);

            //Assert
            Assert.AreEqual("full orchestra", myInstrumentation.InstrumentationName);
        }

        [TestMethod]
        public void TestInstrumentationConstructor_FieldInstrumentationNameIsSetAsLowerCase()
        {
            //Arrange
            Instrumentation myInstrumentation;

            //Act
            myInstrumentation = new Instrumentation("Full Orchestra", false);

            //Assert
            Assert.AreEqual("full orchestra", myInstrumentation.InstrumentationName);
        }

        [TestMethod]
        public void TestInstrumentation_MethodIncrementNumberOfTimesUsed()
        {
            //Arrange
            Instrumentation myInstrumentation = new Instrumentation("Full Orchestra", false);

            //Act
            myInstrumentation.IncrementNumberOfTimesUsed();

            //Assert
            Assert.AreEqual(2, myInstrumentation.NumberOfTimesUsed);
        }

        [TestMethod]
        public void TestInstrumentation_MethodIncrementNumberOfTimesUsedTriggersFieldApprovedToBeTrue()
        {
            //Arrange
            Instrumentation myInstrumentation = new Instrumentation("Full Orchestra", false);

            //Act
            for (int i = 0; i <= 48; i++)
            {
                myInstrumentation.IncrementNumberOfTimesUsed();
            }

            //Assert
            Assert.AreEqual(true, myInstrumentation.Approved);
        }
        
    }
}
