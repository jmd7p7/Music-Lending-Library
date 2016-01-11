using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using LendingLibrary_Library.MusicSelection;
using LendingLibrary_Library.Utility;
using System.Collections.Generic;

namespace LendingLibrary_Library_Tests.MusicSelectionTests
{
    [TestClass]
    public class MusicSelectionTests
    {
        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException), "In class MusicSelection, constructor (no _id).  String argument institution_id cannot be null.")]
        public void MusicSelection_ConstructorNoId_StringArgumentInstitution_idIsNull_ThrowsArgumentNullException()
        {
            //Arrange
            MusicSelectionMock myMusicSelection;
            Contributor composer = new Contributor(new Name("David", "", "Haas"), "Composer");

            //Act
            myMusicSelection = new MusicSelectionMock(null, "Blest Are They", composer);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException), "In class MusicSelection, constructor (no _id).  String argument institution_id cannot be empty.")]
        public void MusicSelection_ConstructorNoId_StringArgumentInstitution_idIsEmpty_ThrowsArgumentException()
        {
            //Arrange
            MusicSelectionMock myMusicSelection;
            Contributor composer = new Contributor(new Name("David", "", "Haas"), "Composer");

            //Act
            myMusicSelection = new MusicSelectionMock("", "Blest Are They", composer);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException), "In class MusicSelection, constructor (no _id).  String argument institution_id cannot be a white string.")]
        public void MusicSelection_ConstructorNoId_StringArgumentInstitution_idIsWhiteString_ThrowsArgumentException()
        {
            //Arrange
            MusicSelectionMock myMusicSelection;
            Contributor composer = new Contributor(new Name("David", "", "Haas"), "Composer");

            //Act
            myMusicSelection = new MusicSelectionMock("  ", "Blest Are They", composer);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException), "In class MusicSelection, constructor (no _id).  String argument title cannot be null.")]
        public void MusicSelection_ConstructorNoId_StringArgumentTitleIsNull_ThrowsArgumentNullException()
        {
            //Arrange
            MusicSelectionMock myMusicSelection;
            Contributor composer = new Contributor(new Name("David", "", "Haas"), "Composer");

            //Act
            myMusicSelection = new MusicSelectionMock("507f191e810c19729de860ea", null, composer);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException), "In class MusicSelection, constructor (no _id).  String argument title cannot be empty.")]
        public void MusicSelection_ConstructorNoId_StringArgumentTitleIsEmpty_ThrowsArgumentException()
        {
            //Arrange
            MusicSelectionMock myMusicSelection;
            Contributor composer = new Contributor(new Name("David", "", "Haas"), "Composer");

            //Act
            myMusicSelection = new MusicSelectionMock("507f191e810c19729de860ea", "", composer);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException), "In class MusicSelection, constructor (no _id).  String argument title cannot be white space.")]
        public void MusicSelection_ConstructorNoId_StringArgumentTitleIsWhiteSpace_ThrowsArgumentException()
        {
            //Arrange
            MusicSelectionMock myMusicSelection;
            Contributor composer = new Contributor(new Name("David", "", "Haas"), "Composer");

            //Act
            myMusicSelection = new MusicSelectionMock("507f191e810c19729de860ea", "    ", composer);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException), "In class MusicSelection, constructor (no _id).  Argument composer cannot be null.")]
        public void MusicSelection_ConstructorNoId_ArgumentComposerIsWhiteSpace_ThrowsArgumentNullException()
        {
            //Arrange
            MusicSelectionMock myMusicSelection;

            //Act
            myMusicSelection = new MusicSelectionMock("507f191e810c19729de860ea", "Blest Are They", null);
        }

        [TestMethod]
        public void MusicSelection_ConstructorNoId_ArgumentInstitution_idIsSetCorrectly()
        {
            //Arrange
            MusicSelectionMock myMusicSelection;
            Contributor composer = new Contributor(new Name("David", "", "Haas"), "Composer");

            //Act
            myMusicSelection = new MusicSelectionMock("507f191e810c19729de860ea", "Blest Are They", composer);

            //Assert
            Assert.AreEqual("507f191e810c19729de860ea", myMusicSelection.Institution_id);
        }

        [TestMethod]
        public void MusicSelection_ConstructorNoId_ArgumentTitleIsSetCorrectly()
        {
            //Arrange
            MusicSelectionMock myMusicSelection;
            Contributor composer = new Contributor(new Name("David", "", "Haas"), "Composer");

            //Act
            myMusicSelection = new MusicSelectionMock("507f191e810c19729de860ea", " Blest Are They ", composer);

            //Assert
            Assert.AreEqual("Blest Are They", myMusicSelection.Title);
        }

        [TestMethod]
        public void MusicSelection_ConstructorNoId_ArgumentTitle_LowerCaseIsSetCorrectly()
        {
            //Arrange
            MusicSelectionMock myMusicSelection;
            Contributor composer = new Contributor(new Name("David", "", "Haas"), "Composer");

            //Act
            myMusicSelection = new MusicSelectionMock("507f191e810c19729de860ea", " Blest Are They ", composer);

            //Assert
            Assert.AreEqual("blest are they", myMusicSelection.Title_LowerCase);
        }


        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException), "In class MusicSelection, constructor (with _id).  String argument institution_id cannot be null.")]
        public void MusicSelection_ConstructorWithId_StringArgumentInstitution_idIsNull_ThrowsArgumentNullException()
        {
            //Arrange
            MusicSelectionMock myMusicSelection;
            Contributor composer = new Contributor(new Name("David", "", "Haas"), "Composer");

            //Act
            myMusicSelection = new MusicSelectionMock("507f191e810c19729de860ea", null, "Blest Are They", composer);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException), "In class MusicSelection, constructor (with _id).  String argument institution_id cannot be empty.")]
        public void MusicSelection_ConstructorWithId_StringArgumentInstitution_idIsEmpty_ThrowsArgumentException()
        {
            //Arrange
            MusicSelectionMock myMusicSelection;
            Contributor composer = new Contributor(new Name("David", "", "Haas"), "Composer");

            //Act
            myMusicSelection = new MusicSelectionMock("507f191e810c19729de860ea", "", "Blest Are They", composer);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException), "In class MusicSelection, constructor (with _id).  String argument institution_id cannot be a white string.")]
        public void MusicSelection_ConstructorWithId_StringArgumentInstitution_idIsWhiteSpace_ThrowsArgumentException()
        {
            //Arrange
            MusicSelectionMock myMusicSelection;
            Contributor composer = new Contributor(new Name("David", "", "Haas"), "Composer");

            //Act
            myMusicSelection = new MusicSelectionMock("507f191e810c19729de860ea", "   ", "Blest Are They", composer);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException), "In class MusicSelection, constructor (with _id).  String argument title cannot be null.")]
        public void MusicSelection_ConstructorWithId_StringArgumentTitleIsNull_ThrowsArgumentNullException()
        {
            //Arrange
            MusicSelectionMock myMusicSelection;
            Contributor composer = new Contributor(new Name("David", "", "Haas"), "Composer");

            //Act
            myMusicSelection = new MusicSelectionMock("9999991e810c19729de860ea", "507f191e810c19729de860ea", null, composer);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException), "In class MusicSelection, constructor (with _id).  String argument title cannot be empty.")]
        public void MusicSelection_ConstructorWithId_StringArgumentTitleIsEmpty_ThrowsArgumentException()
        {
            //Arrange
            MusicSelectionMock myMusicSelection;
            Contributor composer = new Contributor(new Name("David", "", "Haas"), "Composer");

            //Act
            myMusicSelection = new MusicSelectionMock("9999991e810c19729de860ea", "507f191e810c19729de860ea", "", composer);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException), "In class MusicSelection, constructor (with _id).  String argument title cannot be white space.")]
        public void MusicSelection_ConstructorWithId_StringArgumentTitleIsWhiteSpace_ThrowsArgumentException()
        {
            //Arrange
            MusicSelectionMock myMusicSelection;
            Contributor composer = new Contributor(new Name("David", "", "Haas"), "Composer");

            //Act
            myMusicSelection = new MusicSelectionMock("9999991e810c19729de860ea", "507f191e810c19729de860ea", "    ", composer);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException), "In class MusicSelection, constructor (with _id).  Argument composer cannot be null.")]
        public void MusicSelection_ConstructorWithId_ArgumentComposerIsWhiteSpace_ThrowsArgumentNullException()
        {
            //Arrange
            MusicSelectionMock myMusicSelection;

            //Act
            myMusicSelection = new MusicSelectionMock("9999991e810c19729de860ea", "507f191e810c19729de860ea", "Blest Are They", null);
        }

        [TestMethod]
        public void MusicSelection_ConstructorWithId_ArgumentIdIsSetCorrectly()
        {
            //Arrange
            MusicSelectionMock myMusicSelection;
            Contributor composer = new Contributor(new Name("David", "", "Haas"), "Composer");

            //Act
            myMusicSelection = new MusicSelectionMock("9999991e810c19729de860ea", "507f191e810c19729de860ea", "Blest Are They", composer);

            //Assert
            Assert.AreEqual("9999991e810c19729de860ea", myMusicSelection._id);
        }

        [TestMethod]
        public void MusicSelection_ConstructorWithId_ArgumentInstitute_IdIsSetCorrectly()
        {
            //Arrange
            MusicSelectionMock myMusicSelection;
            Contributor composer = new Contributor(new Name("David", "", "Haas"), "Composer");

            //Act
            myMusicSelection = new MusicSelectionMock("9999991e810c19729de860ea", "507f191e810c19729de860ea", "Blest Are They", composer);

            //Assert
            Assert.AreEqual("507f191e810c19729de860ea", myMusicSelection.Institution_id);
        }

        [TestMethod]
        public void MusicSelection_ConstructorWithId_ArgumentTitleIsSetCorrectly()
        {
            //Arrange
            MusicSelectionMock myMusicSelection;
            Contributor composer = new Contributor(new Name("David", "", "Haas"), "Composer");

            //Act
            myMusicSelection = new MusicSelectionMock("9999991e810c19729de860ea", "507f191e810c19729de860ea", "Blest Are They", composer);

            //Assert
            Assert.AreEqual("Blest Are They", myMusicSelection.Title);
        }

        [TestMethod]
        public void MusicSelection_ConstructorWithId_ArgumentTitle_LowerCaseIsSetCorrectly()
        {
            //Arrange
            MusicSelectionMock myMusicSelection;
            Contributor composer = new Contributor(new Name("David", "", "Haas"), "Composer");

            //Act
            myMusicSelection = new MusicSelectionMock("9999991e810c19729de860ea", "507f191e810c19729de860ea", "Blest Are They", composer);

            //Assert
            Assert.AreEqual("blest are they", myMusicSelection.Title_LowerCase);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException), "In abstract class MusicSelection, method setTitle().  Argument title cannot be null.")]
        public void MusicSelection_MethodSetTitle_ArgumentTitleIsNull_ThrowsArgumentNullException()
        {
            //Arrange
            Contributor composer = new Contributor(new Name("David", "", "Haas"), "Composer");
            MusicSelectionMock myMusicSelection =
                new MusicSelectionMock("9999991e810c19729de860ea", "507f191e810c19729de860ea", "Blest Are They", composer);

            //Act
            myMusicSelection.setTitle(null);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException), "In abstract class MusicSelection, method setTitle().  Argument title cannot be empty.")]
        public void MusicSelection_MethodSetTitle_ArgumentTitleIsEmpty_ThrowsArgumentException()
        {
            //Arrange
            Contributor composer = new Contributor(new Name("David", "", "Haas"), "Composer");
            MusicSelectionMock myMusicSelection =
                new MusicSelectionMock("9999991e810c19729de860ea", "507f191e810c19729de860ea", "Blest Are They", composer);

            //Act
            myMusicSelection.setTitle("");
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException), "In abstract class MusicSelection, method setTitle().  Argument title cannot be white space.")]
        public void MusicSelection_MethodSetTitle_ArgumentTitleIsWhiteSpace_ThrowsArgumentException()
        {
            //Arrange
            Contributor composer = new Contributor(new Name("David", "", "Haas"), "Composer");
            MusicSelectionMock myMusicSelection =
                new MusicSelectionMock("9999991e810c19729de860ea", "507f191e810c19729de860ea", "Blest Are They", composer);

            //Act
            myMusicSelection.setTitle("   ");
        }

       [TestMethod]
       public void MusicSelection_MethodSetTitle_FieldTitleSetCorrectly()
        {
            //Arrange
            Contributor composer = new Contributor(new Name("David", "", "Haas"), "Composer");
            MusicSelectionMock myMusicSelection =
                new MusicSelectionMock("9999991e810c19729de860ea", "507f191e810c19729de860ea", "Blest Are They", composer);

            //Act
            myMusicSelection.setTitle(" You Are Mine ");

           //Assert
            Assert.AreEqual("You Are Mine", myMusicSelection.Title);
        }

       [TestMethod]
       public void MusicSelection_MethodSetTitle_FieldTitle_LowerCaseSetCorrectly()
       {
           //Arrange
           Contributor composer = new Contributor(new Name("David", "", "Haas"), "Composer");
           MusicSelectionMock myMusicSelection =
               new MusicSelectionMock("9999991e810c19729de860ea", "507f191e810c19729de860ea", "Blest Are They", composer);

           //Act
           myMusicSelection.setTitle(" You Are Mine ");

           //Assert
           Assert.AreEqual("you are mine", myMusicSelection.Title_LowerCase);
       }

       [TestMethod]
       [ExpectedException(typeof(ArgumentNullException), "In abstract class MusicSelection, method setComposer().  Argument composer cannot be white space.")]
       public void MusicSelection_MethodSetComposer_ArgumentComposerIsNull_ThrowsArgumentNullException()
       {
           //Arrange
           Contributor composer = new Contributor(new Name("David", "", "Haas"), "Composer");
           MusicSelectionMock myMusicSelection =
               new MusicSelectionMock("9999991e810c19729de860ea", "507f191e810c19729de860ea", "Blest Are They", composer);

           //Act
           myMusicSelection.setComposer(null);
       }

       [TestMethod]
       [ExpectedException(typeof(ArgumentException), "In abstract class MusicSelection, method setComposer().  The argument, of type Contributor, did not have its role set to composer.")]
       public void MusicSelection_MethodSetComposer_ArgumentDoesNotHaveFieldRoleSetToComposer_ThrowsArgumentException()
       {
           //Arrange
           Contributor composer = new Contributor(new Name("David", "", "Haas"), "Composer");
           Contributor arranger = new Contributor(new Name("Joe", "L", "Doe"), "Arranger");
           MusicSelectionMock myMusicSelection =
               new MusicSelectionMock("9999991e810c19729de860ea", "507f191e810c19729de860ea", "Blest Are They", composer);

           //Act
           myMusicSelection.setComposer(arranger);
       }

       [TestMethod]
       public void MusicSelection_MethodSetComposer()
       {
           //Arrange
           Contributor composer = new Contributor(new Name("David", "", "Haas"), "Composer");
           Contributor newComposer = new Contributor(new Name("Joe", "L", "Doe"), " Composer ");
           MusicSelectionMock myMusicSelection =
               new MusicSelectionMock("9999991e810c19729de860ea", "507f191e810c19729de860ea", "Blest Are They", composer);

           //Act
           myMusicSelection.setComposer(newComposer);

           //Assert
           Assert.AreEqual("Composer", myMusicSelection.Composer.Role);
       }


       [TestMethod]
       public void MusicSelection_MethodSetPublisher_FieldPublisherSetCorrectly()
       {
           //Arrange
           Contributor composer = new Contributor(new Name("David", "", "Haas"), "Composer");
           MusicSelectionMock myMusicSelection =
               new MusicSelectionMock("9999991e810c19729de860ea", "507f191e810c19729de860ea", "Blest Are They", composer);

           //Act
           myMusicSelection.setPublisher("Acme Publishing");

           //Assert
           Assert.AreEqual("Acme Publishing", myMusicSelection.Publisher);
       }

       [TestMethod]
       public void MusicSelection_MethodSetPublisher_FieldPublisher_LowerCaseSetCorrectly()
       {
           //Arrange
           Contributor composer = new Contributor(new Name("David", "", "Haas"), "Composer");
           MusicSelectionMock myMusicSelection =
               new MusicSelectionMock("9999991e810c19729de860ea", "507f191e810c19729de860ea", "Blest Are They", composer);

           //Act
           myMusicSelection.setPublisher("Acme Publishing");

           //Assert
           Assert.AreEqual("acme publishing", myMusicSelection.Publisher_LowerCase);
       }

       [TestMethod]
       public void MusicSelection_MethodSetItemNumber_FieldItemNumberSetCorrectly()
       {
           //Arrange
           Contributor composer = new Contributor(new Name("David", "", "Haas"), "Composer");
           MusicSelectionMock myMusicSelection =
               new MusicSelectionMock("9999991e810c19729de860ea", "507f191e810c19729de860ea", "Blest Are They", composer);

           //Act
           myMusicSelection.setItemNumber("ABC123");

           //Assert
           Assert.AreEqual("ABC123", myMusicSelection.ItemNumber);
       }

       [TestMethod]
       public void MusicSelection_MethodSetItemNumber_FieldItemNumber_LowerCaseSetCorrectly()
       {
           //Arrange
           Contributor composer = new Contributor(new Name("David", "", "Haas"), "Composer");
           MusicSelectionMock myMusicSelection =
               new MusicSelectionMock("9999991e810c19729de860ea", "507f191e810c19729de860ea", "Blest Are They", composer);

           //Act
           myMusicSelection.setItemNumber("ABC123");

           //Assert
           Assert.AreEqual("abc123", myMusicSelection.ItemNumber_LowerCase);
       }

       [TestMethod]
       public void MusicSelection_MethodSetNotes_FieldNotesSetCorrectly()
       {
           //Arrange
           Contributor composer = new Contributor(new Name("David", "", "Haas"), "Composer");
           MusicSelectionMock myMusicSelection =
               new MusicSelectionMock("9999991e810c19729de860ea", "507f191e810c19729de860ea", "Blest Are They", composer);

           //Act
           myMusicSelection.setNotes("Here are some nice notes.");

           //Assert
           Assert.AreEqual("Here are some nice notes.", myMusicSelection.Notes);
       }

       [TestMethod]
       public void MusicSelection_MethodSetPerformanceNotes_FieldPerformanceNotesSetCorrectly()
       {
           //Arrange
           Contributor composer = new Contributor(new Name("David", "", "Haas"), "Composer");
           MusicSelectionMock myMusicSelection =
               new MusicSelectionMock("9999991e810c19729de860ea", "507f191e810c19729de860ea", "Blest Are They", composer);

           //Act
           myMusicSelection.setPerformanceNotes("Here are some nice performance notes.");

           //Assert
           Assert.AreEqual("Here are some nice performance notes.", myMusicSelection.PerformanceNotes);
       }


       [TestMethod]
       public void MusicSelection_MethodSetPerformanceNotesArePublic_FieldPerformanceNotesArePublicSetCorrectly()
       {
           //Arrange
           Contributor composer = new Contributor(new Name("David", "", "Haas"), "Composer");
           MusicSelectionMock myMusicSelection =
               new MusicSelectionMock("9999991e810c19729de860ea", "507f191e810c19729de860ea", "Blest Are They", composer);

           //Act
           myMusicSelection.setPerformanceNotesArePublic(true);

           //Assert
           Assert.AreEqual(true, myMusicSelection.PerformanceNotesArePublic);
       }

       [TestMethod]
       public void MusicSelection_MethodSetIsLendable_FieldIsLendableSetCorrectly()
       {
           //Arrange
           Contributor composer = new Contributor(new Name("David", "", "Haas"), "Composer");
           MusicSelectionMock myMusicSelection =
               new MusicSelectionMock("9999991e810c19729de860ea", "507f191e810c19729de860ea", "Blest Are They", composer);

           //Act
           myMusicSelection.setIsLendable(true);

           //Assert
           Assert.AreEqual(true, myMusicSelection.IsLendable);
       }

       [TestMethod]
       public void MusicSelection_MethodSetDifficultyLevel_FieldDifficultyLevelSetCorrectly()
       {
           //Arrange
           Contributor composer = new Contributor(new Name("David", "", "Haas"), "Composer");
           MusicSelectionMock myMusicSelection =
               new MusicSelectionMock("9999991e810c19729de860ea", "507f191e810c19729de860ea", "Blest Are They", composer);

           //Act
           myMusicSelection.setDifficultyLevel(" Hard ");

           //Assert
           Assert.AreEqual("Hard", myMusicSelection.DifficultyLevel);
       }

       [TestMethod]
       public void MusicSelection_MethodSetDifficultyLevel_FieldDifficultyLevel_LowerCaseSetCorrectly()
       {
           //Arrange
           Contributor composer = new Contributor(new Name("David", "", "Haas"), "Composer");
           MusicSelectionMock myMusicSelection =
               new MusicSelectionMock("9999991e810c19729de860ea", "507f191e810c19729de860ea", "Blest Are They", composer);

           //Act
           myMusicSelection.setDifficultyLevel(" Hard ");

           //Assert
           Assert.AreEqual("hard", myMusicSelection.DifficultyLevel_LowerCase);
       }

       [TestMethod]
       public void MusicSelection_MethodSetGenre_FieldGenreSetCorrectly()
       {
           //Arrange
           Contributor composer = new Contributor(new Name("David", "", "Haas"), "Composer");
           MusicSelectionMock myMusicSelection =
               new MusicSelectionMock("9999991e810c19729de860ea", "507f191e810c19729de860ea", "Blest Are They", composer);

           //Act
           myMusicSelection.setGenre(" Chant ");

           //Assert
           Assert.AreEqual("Chant", myMusicSelection.Genre);
       }

       [TestMethod]
       public void MusicSelection_MethodSetGenre_FieldGenre_LowerCaseSetCorrectly()
       {
           //Arrange
           Contributor composer = new Contributor(new Name("David", "", "Haas"), "Composer");
           MusicSelectionMock myMusicSelection =
               new MusicSelectionMock("9999991e810c19729de860ea", "507f191e810c19729de860ea", "Blest Are They", composer);

           //Act
           myMusicSelection.setGenre(" Chant ");

           //Assert
           Assert.AreEqual("chant", myMusicSelection.Genre_LowerCase);
       }

       [TestMethod]
       public void MusicSelection_MethodSetInstrumentation_FieldInstrumentationSetCorrectly()
       {
           //Arrange
           Contributor composer = new Contributor(new Name("David", "", "Haas"), "Composer");
           MusicSelectionMock myMusicSelection =
               new MusicSelectionMock("9999991e810c19729de860ea", "507f191e810c19729de860ea", "Blest Are They", composer);

           //Act
           myMusicSelection.setInstrumentation("  Organ and Brass ");

           //Assert
           Assert.AreEqual("Organ and Brass", myMusicSelection.Instrumentation);
       }

       [TestMethod]
       public void MusicSelection_MethodSetInstrumentation_FieldInstrumentation_LowerCaseSetCorrectly()
       {
           //Arrange
           Contributor composer = new Contributor(new Name("David", "", "Haas"), "Composer");
           MusicSelectionMock myMusicSelection =
               new MusicSelectionMock("9999991e810c19729de860ea", "507f191e810c19729de860ea", "Blest Are They", composer);

           //Act
           myMusicSelection.setInstrumentation("  Organ and Brass ");

           //Assert
           Assert.AreEqual("organ and brass", myMusicSelection.Instrumentation_LowerCase);
       }

       [TestMethod]
       public void MusicSelection_MethodAddTag_AddingNewTag()
       {
           //Arrange
           Contributor composer = new Contributor(new Name("David", "", "Haas"), "Composer");
           MusicSelectionMock myMusicSelection =
               new MusicSelectionMock("9999991e810c19729de860ea", "507f191e810c19729de860ea", "Blest Are They", composer);
           Tag myTag = new Tag("Easter");

           //Act
           myMusicSelection.addTag(myTag);

           //Assert
           Assert.AreEqual(myTag.TagName, myMusicSelection.getTags()[0].TagName);
       }

       [TestMethod]
       public void MusicSelection_MethodAddTag_AttemptToAddDuplicateTag_DoesNotAddTheTag()
       {
           //Arrange
           Contributor composer = new Contributor(new Name("David", "", "Haas"), "Composer");
           MusicSelectionMock myMusicSelection =
               new MusicSelectionMock("9999991e810c19729de860ea", "507f191e810c19729de860ea", "Blest Are They", composer);
           Tag myTag = new Tag("Easter");
           myMusicSelection.addTag(myTag);

           //Act
           myMusicSelection.addTag(myTag);

           //Assert
           Assert.AreEqual(1, myMusicSelection.getTags().Count);
       }


       [TestMethod]
       [ExpectedException(typeof(ArgumentNullException), "In abstract class MusicSelection, method removeTag(). The argument tag cannot be null.")]
       public void MusicSelection_MethodRemoveTag_ArgumentTagIsNull_ThrowsArgumentNullException()
       {
           //Arrange
           Contributor composer = new Contributor(new Name("David", "", "Haas"), "Composer");
           MusicSelectionMock myMusicSelection =
               new MusicSelectionMock("9999991e810c19729de860ea", "507f191e810c19729de860ea", "Blest Are They", composer);
           Tag myTag = new Tag("Easter");
           myMusicSelection.addTag(myTag);

           //Act
           myMusicSelection.removeTag(null);
       }

       [TestMethod]
       [ExpectedException(typeof(ArgumentException), "In abstract class MusicSelection, method removeTag(). Unable to remove tag that does not exist in the list.")]
       public void MusicSelection_MethodRemoveTag_AttemptToRemoveExistingTag_ThrowsArgumentException()
       {
           //Arrange
           Contributor composer = new Contributor(new Name("David", "", "Haas"), "Composer");
           MusicSelectionMock myMusicSelection =
               new MusicSelectionMock("9999991e810c19729de860ea", "507f191e810c19729de860ea", "Blest Are They", composer);
           Tag myTag = new Tag("Easter");
           myMusicSelection.addTag(myTag);

           //Act
           Tag myTag2 = new Tag("Lent");
           myMusicSelection.removeTag(myTag2);
       }

       [TestMethod]
       public void MusicSelection_MethodRemoveTag()
       {
           //Arrange
           Contributor composer = new Contributor(new Name("David", "", "Haas"), "Composer");
           MusicSelectionMock myMusicSelection =
               new MusicSelectionMock("9999991e810c19729de860ea", "507f191e810c19729de860ea", "Blest Are They", composer);
           Tag myTag = new Tag("Easter");
           Tag myTag2 = new Tag("Lent");
           myMusicSelection.addTag(myTag);
           myMusicSelection.addTag(myTag2);
           List<Tag> expectedValue = new List<Tag> { myTag };

           //Act
           myMusicSelection.removeTag(myTag2);

           //Assert
           CollectionAssert.AreEqual(expectedValue, myMusicSelection.getTags());
       }

       [TestMethod]
       [ExpectedException(typeof(ArgumentNullException), "In abstract class MusicSelection, method addContributor(). Argument cannot be null.")]
       public void MusicSelection_MethodAddContributor_ArgumentContributorIsNull_ThrowsArgumentNullException()
       {
           //Arrange
           Contributor composer = new Contributor(new Name("David", "", "Haas"), "Composer");
           MusicSelectionMock myMusicSelection =
               new MusicSelectionMock("9999991e810c19729de860ea", "507f191e810c19729de860ea", "Blest Are They", composer);

           //Act
           myMusicSelection.addContributor(null);
       }

       [TestMethod]
       public void MusicSelection_MethodAddContributor()
       {
           //Arrange
           Contributor composer = new Contributor(new Name("David", "", "Haas"), "Composer");
           MusicSelectionMock myMusicSelection =
               new MusicSelectionMock("9999991e810c19729de860ea", "507f191e810c19729de860ea", "Blest Are They", composer);

           //Act
           Contributor arranger = new Contributor(new Name("Billy", "", "Bob"), "Arranger");
           List<Contributor> expectedValue = new List<Contributor>() { arranger };
           myMusicSelection.addContributor(arranger);

           //Assert
           CollectionAssert.AreEqual(expectedValue, myMusicSelection.getContributors());
       }

       [TestMethod]
       public void MusicSelection_MethodAddContributorThatAlreadyExistDoesNotModifyTheList()
       {
           //Arrange
           Contributor composer = new Contributor(new Name("David", "", "Haas"), "Composer");
           MusicSelectionMock myMusicSelection =
               new MusicSelectionMock("9999991e810c19729de860ea", "507f191e810c19729de860ea", "Blest Are They", composer);

           //Act
           Contributor arranger = new Contributor(new Name("Billy", "", "Bob"), "Arranger");
           List<Contributor> expectedValue = new List<Contributor>() { arranger };
           myMusicSelection.addContributor(arranger);
           myMusicSelection.addContributor(arranger);

           //Assert
           CollectionAssert.AreEqual(expectedValue, myMusicSelection.getContributors());
       }

       [TestMethod]
       [ExpectedException(typeof(ArgumentNullException), "In abstract class MusicSelection, method removeContributor(). Argument cannot be null.")]
       public void MusicSelection_RemoveContributor_ArgumentContributorIsNull_ThrowsArgumentNullException()
       {
           //Arrange
           Contributor composer = new Contributor(new Name("David", "", "Haas"), "Composer");
           MusicSelectionMock myMusicSelection =
               new MusicSelectionMock("9999991e810c19729de860ea", "507f191e810c19729de860ea", "Blest Are They", composer);

           //Act
           myMusicSelection.removeContributor(null);
       }

       [TestMethod]
       [ExpectedException(typeof(ArgumentException), "In class MusicSelection, method removeContributor(). Unable to remove contributor that does not exist in the list.")]
       public void MusicSelection_RemoveContributor_AttemptToRemoveContributorThatDoesNotExistIntheList_ThrowsArgumentException()
       {
           //Arrange
           Contributor composer = new Contributor(new Name("David", "", "Haas"), "Composer");
           MusicSelectionMock myMusicSelection =
               new MusicSelectionMock("9999991e810c19729de860ea", "507f191e810c19729de860ea", "Blest Are They", composer);
           Contributor contributor1 = new Contributor(new Name("Billy", "", "Bob"), "Arranger");
           Contributor contributor2 = new Contributor(new Name("Jane", "", "Jones"), "Editor");


           //Act
           myMusicSelection.addContributor(contributor1);
           myMusicSelection.removeContributor(contributor2);
       }

       [TestMethod]
       public void MusicSelection_RemoveContributor()
       {
           //Arrange
           Contributor composer = new Contributor(new Name("David", "", "Haas"), "Composer");
           MusicSelectionMock myMusicSelection =
               new MusicSelectionMock("9999991e810c19729de860ea", "507f191e810c19729de860ea", "Blest Are They", composer);
           Contributor contributor1 = new Contributor(new Name("Billy", "", "Bob"), "Arranger");
           Contributor contributor2 = new Contributor(new Name("Jane", "", "Jones"), "Editor");
           Contributor contributor3 = new Contributor(new Name("Frank", "", "Williams"), "Arranger");
           List<Contributor> expectedValue = new List<Contributor>() { contributor1, contributor3 };

           //Act
           myMusicSelection.addContributor(contributor1);
           myMusicSelection.addContributor(contributor2);
           myMusicSelection.addContributor(contributor3);
           myMusicSelection.removeContributor(contributor2);

           //Assert
           CollectionAssert.AreEqual(expectedValue, myMusicSelection.getContributors());
       }
    }





    public class MusicSelectionMock : MusicSelection { 
        public MusicSelectionMock(String id, String institution_Id, String title, Contributor composer)
        :base(id, institution_Id, title, composer){} 

        public MusicSelectionMock(String institution_Id, String title, Contributor composer)
        :base(institution_Id, title, composer){} 
    }
}
