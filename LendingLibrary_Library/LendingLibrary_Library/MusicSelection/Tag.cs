using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LendingLibrary_Library.Utility;

namespace LendingLibrary_Library.MusicSelection
{

    //Note: I did override Equals but NOT GetHashCode
    public class Tag
    {
        public String TagName { get; private set; }
        public String TagName_LowerCase { get; private set; }
        public Tag(String tagName)
        {
            try
            {
                ErrorChecking.CheckStringForNullEmptyOrWhiteSpace_ThrowException(tagName);
            }
            catch (ArgumentNullException ex)
            {
                throw new ArgumentNullException("In class Tag, constructor, argument tagName. " + ex.Message);
            }
            catch (ArgumentException ex)
            {
                throw new ArgumentException("In class Tag, constructor, argument tagName. " + ex.Message);
            }
            this.TagName = tagName.Trim();
            this.TagName_LowerCase = tagName.Trim().ToLower();
        }


        public override bool Equals(Object obj)
        {
            // If parameter is null return false.
            if (obj == null)
            {
                return false;
            }

            // If parameter cannot be cast to Tag return false.
            Tag tag = obj as Tag;
            if ((System.Object)tag == null)
            {
                return false;
            }

            // Return true if the fields match:
            return (this.TagName == tag.TagName) && (this.TagName_LowerCase == tag.TagName_LowerCase);
        }

        public override int GetHashCode()
        {
            //John Skeet's implementation of GetHashCode()
            //http://stackoverflow.com/questions/263400/what-is-the-best-algorithm-for-an-overridden-system-object-gethashcode/263416#263416

            unchecked // Overflow is fine, just wrap
            {
                int hash = 17;
                hash = this.TagName == null ? hash : hash * 23 + this.TagName.GetHashCode();
                hash = this.TagName_LowerCase == null ? hash : hash * 23 + this.TagName_LowerCase.GetHashCode();
                return hash;
            }
        }
    }
}
