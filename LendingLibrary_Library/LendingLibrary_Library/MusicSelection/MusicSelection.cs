using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LendingLibrary_Library.Utility;

namespace LendingLibrary_Library.MusicSelection
{
    public abstract class MusicSelection
    {
        public String _id { get; private set; }
        public String Institution_id { get; private set; }
        public String Title { get; private set; }
        public String Title_LowerCase { get; private set; }
        public Contributor Composer { get; private set; }
        public String Publisher { get; private set; }
        public String Publisher_LowerCase { get; private set; }
        public String ItemNumber { get; private set; }
        public String ItemNumber_LowerCase { get; private set; }
        public String Notes { get; private set; }
        public String PerformanceNotes { get; private set; }
        public Boolean PerformanceNotesArePublic { get; private set; }
        public Boolean IsLendable { get; private set; }
        public String DifficultyLevel { get; private set; }
        public String DifficultyLevel_LowerCase { get; private set; }
        public String Genre { get; private set; }
        public String Genre_LowerCase { get; private set; }
        public String Instrumentation { get; private set; }
        public String Instrumentation_LowerCase { get; private set; }

        private List<Tag> Tags;

        private List<Contributor> Contributors;

        public MusicSelection(String id, String institution_Id, String title, Contributor composer)
        {
            try
            {
                ErrorChecking.CheckStringForNullEmptyOrWhiteSpace_ThrowException(id);
                ErrorChecking.CheckStringForNullEmptyOrWhiteSpace_ThrowException(institution_Id);
                ErrorChecking.CheckStringForNullEmptyOrWhiteSpace_ThrowException(title);
                ErrorChecking.CheckObjectForNull(composer);

                this._id = id;
                this.Institution_id = institution_Id;
                this.Title = title.Trim();
                this.Title_LowerCase = title.Trim().ToLower();
                this.Composer = composer;
                this.Publisher = "";
                this.Publisher_LowerCase = "";
                this.ItemNumber = "";
                this.ItemNumber_LowerCase = "";
                this.Notes = "";
                this.PerformanceNotes = "";
                this.PerformanceNotesArePublic = false;
                this.IsLendable = false;
                this.DifficultyLevel = "";
                this.DifficultyLevel_LowerCase = "";
                this.Genre = "";
                this.Genre_LowerCase = "";
                this.Instrumentation = "";
                this.Instrumentation_LowerCase = "";
                this.Tags = new List<Tag>();
                this.Contributors = new List<Contributor>();
            }
            catch (ArgumentNullException ex)
            {
                throw new ArgumentNullException("In class Music selection, constructor with _id. " + ex.Message);
            }
            catch (ArgumentException ex)
            {
                throw new ArgumentException("In class Music selection, constructor with _id. " + ex.Message);
            }
        }

        public MusicSelection(String institution_Id, String title, Contributor composer)
        {
            try
            {
                ErrorChecking.CheckStringForNullEmptyOrWhiteSpace_ThrowException(institution_Id);
                ErrorChecking.CheckStringForNullEmptyOrWhiteSpace_ThrowException(title);
                ErrorChecking.CheckObjectForNull(composer);

                this._id = "";
                this.Institution_id = institution_Id;
                this.Title = title.Trim();
                this.Title_LowerCase = title.Trim().ToLower();
                this.Composer = composer;
                this.Publisher = "";
                this.Publisher_LowerCase = "";
                this.ItemNumber = "";
                this.ItemNumber_LowerCase = "";
                this.Notes = "";
                this.PerformanceNotes = "";
                this.PerformanceNotesArePublic = false;
                this.IsLendable = false;
                this.DifficultyLevel = "";
                this.DifficultyLevel_LowerCase = "";
                this.Genre = "";
                this.Genre_LowerCase = "";
                this.Instrumentation = "";
                this.Instrumentation_LowerCase = "";
                this.Tags = new List<Tag>();
                this.Contributors = new List<Contributor>();
            }
            catch (ArgumentNullException ex)
            {
                throw new ArgumentNullException("In class Music selection, constructor without _id. " + ex.Message);
            }
            catch (ArgumentException ex)
            {
                throw new ArgumentException("In class Music selection, constructor without _id. " + ex.Message);
            }
        }

        public void setTitle(String title)
        {
            try
            {
                ErrorChecking.CheckStringForNullEmptyOrWhiteSpace_ThrowException(title);
            }
            catch(ArgumentNullException ex)
            {
                throw new ArgumentNullException("In abstract class MusicSelection, method setTitle(), argument title. " + ex.Message);
            }
            catch (ArgumentException ex)
            {
                throw new ArgumentException("In abstract class MusicSelection, method setTitle(), argument title. " + ex.Message);
            }

            this.Title = title.Trim();
            this.Title_LowerCase = title.Trim().ToLower();
        }

        public void setComposer(Contributor composer)
        {
            if (composer == null)
            {
                throw new ArgumentNullException("In abstract class MusicSelection, method setComposer().  Argument composer cannot be null.");
            }
            if (composer.Role_LowerCase != "composer")
            {
                throw new ArgumentException("In abstract class MusicSelection, method setComposer(). The argument, of type Contributor, did not have its role set to composer.");
            }
            this.Composer = composer;
        }

        public void setPublisher(String publisher)
        {
            this.Publisher = String.IsNullOrWhiteSpace(publisher) == true ? "" : publisher.Trim();
            this.Publisher_LowerCase = String.IsNullOrWhiteSpace(publisher) == true ? "" : publisher.Trim().ToLower();
        }

        public void setItemNumber(String itemNumber)
        {
            this.ItemNumber = String.IsNullOrWhiteSpace(itemNumber) == true ? "" : itemNumber.Trim();
            this.ItemNumber_LowerCase = String.IsNullOrWhiteSpace(itemNumber) == true ? "" : itemNumber.Trim().ToLower();
        }

        public void setNotes(String notes)
        {
            this.Notes = String.IsNullOrWhiteSpace(notes) == true ? "" : notes;
        }

        public void setPerformanceNotes(String performanceNotes)
        {
            this.PerformanceNotes = String.IsNullOrWhiteSpace(performanceNotes) == true ? "" : performanceNotes;
        }

        public void setPerformanceNotesArePublic(Boolean performanceNotesArePublic)
        {
            this.PerformanceNotesArePublic = performanceNotesArePublic;
        }

        public void setIsLendable(Boolean isLendable)
        {
            this.IsLendable = isLendable;
        }

        public void setDifficultyLevel(String difficultyLevel)
        {
            this.DifficultyLevel = String.IsNullOrWhiteSpace(difficultyLevel) == true ? "" : difficultyLevel.Trim();
            this.DifficultyLevel_LowerCase = String.IsNullOrWhiteSpace(difficultyLevel) == true ? "" : difficultyLevel.Trim().ToLower();
        }

        public void setGenre(String genre)
        {
            this.Genre = String.IsNullOrWhiteSpace(genre) == true ? "" : genre.Trim();
            this.Genre_LowerCase = String.IsNullOrWhiteSpace(genre) == true ? "" : genre.Trim().ToLower();
        }

        public void setInstrumentation(String instrumentation)
        {
            this.Instrumentation = String.IsNullOrWhiteSpace(instrumentation) == true ? "" : instrumentation.Trim();
            this.Instrumentation_LowerCase = String.IsNullOrWhiteSpace(instrumentation) == true ? "" : instrumentation.Trim().ToLower();
        }

        public void addTag(Tag tag)
        {
            if (this.Tags.Exists(t => t.TagName_LowerCase == tag.TagName_LowerCase))
            {
                return;
            }
            this.Tags.Add(tag);
        }

        public void removeTag(Tag tag)
        {
            if(tag == null)
            {
                throw new ArgumentNullException("In class MusicSelection, method removeTag(). The argument tag cannot be null.");
            }
            if (this.Tags.Exists(t => t.TagName_LowerCase == tag.TagName_LowerCase))
            {
                this.Tags.RemoveAt(Tags.FindIndex(t => t.TagName_LowerCase == tag.TagName_LowerCase));
            }
            else
            {
                throw new ArgumentException("In class MusicSelection, method removeTag(). Unable to remove tag that does not exist in the list.");
            }
        }

        public List<Tag> getTags()
        {
            return this.Tags;
        }

        public void addContributor(Contributor contributor)
        {
            if (contributor == null)
            {
                throw new ArgumentNullException("In abstract class MusicSelection, method addContributor(). Argument cannot be null.");
            }
            if (this.Contributors.Exists(c => c.Role == contributor.Role && c.getFullName() == contributor.getFullName()))
            {
                return;
            }
            this.Contributors.Add(contributor);
        }

        public void removeContributor(Contributor contributor)
        {
            if (contributor == null)
            {
                throw new ArgumentNullException("In abstract class MusicSelection, method removeContributor(). Argument cannot be null.");
            }
            if (this.Contributors.Exists(c => c.Role == contributor.Role && c.getFullName() == contributor.getFullName()))
            {
                this.Contributors.RemoveAt
                    (
                        this.Contributors.FindIndex(c => c.Role == contributor.Role &&
                                                         c.getFullName() == contributor.getFullName())
                    );
            }
            else
            {
                throw new ArgumentException("In class MusicSelection, method removeContributor(). Unable to remove contributor that does not exist in the list.");
            }
        }

        public List<Contributor> getContributors()
        {
            return this.Contributors;
        }
    }
}
