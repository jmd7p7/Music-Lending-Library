using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using LendingLibrary_Library.MusicSelection;


namespace LendingLibrary_Library_Tests
{
    [TestClass]
    public class Label_Tests
    {
        [TestMethod]
        [ExpectedException(typeof(ArgumentException), "Text must be provided for the label.")]
        public void TestLabelConstructorWithNullArgument_ThrowsArgumentException()
        {
            //Arrange
            Label myLabel;

            //Act
            myLabel = new Label(null);

            //Assert
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException), "Text must be provided for the label.")]
        public void TestLabelConstructorWithEmptyStringArgument_ThrowsArgumentException()
        {
            //Arrange
            Label myLabel;

            //Act
            myLabel = new Label("");

            //Assert
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException), "Text must be provided for the label.")]
        public void TestLabelConstructorWithWhiteSpaceArgument_ThrowsArgumentException(){
            //Arrage
            Label myLabel;

            //Act
            myLabel = new Label(" ");

            //Assert
        }

        [TestMethod]
        public void TestThatLabelConstructorTrimsWhiteSpaceArgument()
        {
            //Arrage
            Label myLabel;

            //Act
            myLabel = new Label("  Advent ");

            //Assert
            Assert.AreEqual("Advent", myLabel.LabelName);
        }

        [TestMethod]
        public void TestThatLabel_CountIsInitializedToZero()
        {
            //Arrange
            Label myLabel;

            //Act
            myLabel = new Label("Advent");

            //Assert
            Assert.AreEqual(1, myLabel.Count);
        }

        [TestMethod]
        public void TestLabel_IncrementCount()
        {
            //Arrange
            Label myLabel = new Label("Advent");

            //Act
            myLabel.IncrementCount();

            //Assert
            Assert.AreEqual(2, myLabel.Count);
        }

        [TestMethod]
        public void TestLabel_DecrementCount()
        {
            //Arrange
            Label myLabel = new Label("Advent");

            //Act
            myLabel.DecrementCount();

            //Assert
            Assert.AreEqual(0, myLabel.Count);
        }
    }
}
