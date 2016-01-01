using System;
using LendingLibrary_Library.MusicSelection;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LendingLibrary_Library_Tests
{
    [TestClass]
    public class MusicSelectionInfoForLabelAsLabel_Tests
    {
        [TestMethod]
        public void TestMusicSelectionInfoForLabelAsLabelConstructor_FieldMusicSelectionIdSetProperly()
        {
            //Arrange
            MockMusicSelectionDetailsInfoProvider mockMusicSelectionDetailsInfoProvider =
                new MockMusicSelectionDetailsInfoProvider();

            //Act
            MusicSelectionInfoForLabelAsLabel musicSelectionInfoForLabelAsLabel =
                new MusicSelectionInfoForLabelAsLabel(mockMusicSelectionDetailsInfoProvider, true);

            //Assert
            Assert.AreEqual(musicSelectionInfoForLabelAsLabel.MusicSelectionId, "522bb79455449d881b004d27");
        }

        [TestMethod]
        public void TestMusicSelectionInfoForLabelAsLabelConstructor_FieldMusicSelectionNameSetProperly()
        {
            //Arrange
            MockMusicSelectionDetailsInfoProvider mockMusicSelectionDetailsInfoProvider =
                new MockMusicSelectionDetailsInfoProvider();

            //Act
            MusicSelectionInfoForLabelAsLabel musicSelectionForLabelAsLabel =
                new MusicSelectionInfoForLabelAsLabel(mockMusicSelectionDetailsInfoProvider, true);

            //Assert
            Assert.AreEqual(musicSelectionForLabelAsLabel.MusicSelectionName, "Eye Has Not Seen");
        }

        [TestMethod]
        public void TestMusicSelectionInfoForLabelAsLabelConstructor_FieldComposerNameSetProperly()
        {
            //Arrange
            MockMusicSelectionDetailsInfoProvider mockMusicSelectionDetailsInfoProvider =
                new MockMusicSelectionDetailsInfoProvider();

            //Act
            MusicSelectionInfoForLabelAsLabel musicSelectionForLabelAsLabel =
                new MusicSelectionInfoForLabelAsLabel(mockMusicSelectionDetailsInfoProvider, true);

            //Assert
            Assert.AreEqual(musicSelectionForLabelAsLabel.ComposerName, "Marty Haugen");
        }

        [TestMethod]
        public void TestMusicSelectionInfoForLabelAsLabelConstructor_FieldIsChoralSetProperly()
        {
            //Arrange
            MockMusicSelectionDetailsInfoProvider mockMusicSelectionDetailsInfoProvider =
                new MockMusicSelectionDetailsInfoProvider();

            //Act
            MusicSelectionInfoForLabelAsLabel musicSelectionForLabelAsLabel =
                new MusicSelectionInfoForLabelAsLabel(mockMusicSelectionDetailsInfoProvider, true);

            //Assert
            Assert.AreEqual(musicSelectionForLabelAsLabel.IsChoral, true);
        }

        [TestMethod]
        public void TestMusicSelectionInfoForLabelAsLabelConstructor_FieldCountSetProperly()
        {
            //Arrange
            MockMusicSelectionDetailsInfoProvider mockMusicSelectionDetailsInfoProvider =
                new MockMusicSelectionDetailsInfoProvider();

            //Act
            MusicSelectionInfoForLabelAsLabel musicSelectionForLabelAsLabel =
                new MusicSelectionInfoForLabelAsLabel(mockMusicSelectionDetailsInfoProvider, true);

            //Assert
            Assert.AreEqual(musicSelectionForLabelAsLabel.Count, 1);
        }

        [TestMethod]
        public void TestMusicSelectionInfoForLabelAsLabel_MethodIncrementCount()
        {
            //Arrange
            MockMusicSelectionDetailsInfoProvider mockMusicSelectionDetailsInfoProvider =
                new MockMusicSelectionDetailsInfoProvider();
            MusicSelectionInfoForLabelAsLabel musicSelectionForLabelAsLabel =
                new MusicSelectionInfoForLabelAsLabel(mockMusicSelectionDetailsInfoProvider, true);

            //Act
            musicSelectionForLabelAsLabel.IncrementCount();

            //Assert
            Assert.AreEqual(musicSelectionForLabelAsLabel.Count, 2);
        }

        [TestMethod]
        public void TestMusicSelectionInfoForLabelAsLabel_MethodDecrementCount()
        {
            //Arrange
            MockMusicSelectionDetailsInfoProvider mockMusicSelectionDetailsInfoProvider =
                new MockMusicSelectionDetailsInfoProvider();
            MusicSelectionInfoForLabelAsLabel musicSelectionForLabelAsLabel =
                new MusicSelectionInfoForLabelAsLabel(mockMusicSelectionDetailsInfoProvider, true);

            //Act
            musicSelectionForLabelAsLabel.DecrementCount();

            //Assert
            Assert.AreEqual(musicSelectionForLabelAsLabel.Count, 0);
        }

        [TestMethod]
        [ExpectedException(typeof(InvalidOperationException), "In class MusicSelectionForLabelAsLabel, method DecrementCount().  Cannot decrement field Count when Count is currently zero.")]
        public void TestMusicSelectionInfoForLabelAsLabel_MethodDecrementCountThatIsAlreadyZero_ThrowsInvalidOperationException()
        {
            //Arrange
            MockMusicSelectionDetailsInfoProvider mockMusicSelectionDetailsInfoProvider =
                new MockMusicSelectionDetailsInfoProvider();
            MusicSelectionInfoForLabelAsLabel musicSelectionForLabelAsLabel =
                new MusicSelectionInfoForLabelAsLabel(mockMusicSelectionDetailsInfoProvider, true);

            //Act
            musicSelectionForLabelAsLabel.DecrementCount();
            musicSelectionForLabelAsLabel.DecrementCount();
        }
    }

    public class MockMusicSelectionDetailsInfoProvider : MusicSelectionDetailsProvider
    {

        public string getMusicSelectionId()
        {
            return "522bb79455449d881b004d27";
        }

        public string getComposerName()
        {
            return "Marty Haugen";
        }

        public string getMusicSelectionName()
        {
            return "Eye Has Not Seen";
        }
    }
}
