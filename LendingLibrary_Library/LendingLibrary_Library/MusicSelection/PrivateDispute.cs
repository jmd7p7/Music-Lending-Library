using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LendingLibrary_Library.MusicSelection
{
    //A PrivateDispute represents a user's record of a dispute he/she
    //has with a piece of information concerning a music selection.
    //For instance, a user could dispute the copyright date of a music selection.
    //In this case, the disputed field would be "Copyright Date" and the value
    //the user believes is accurate would be the UserValue
    //
    //This is in contrast to a Dispute, which represents the system's record
    //of a certain disputed piece of information regarding a certain music selection.  
    //For instance, many users could dispute the copyright
    //date of a music selection.  In this case, the Dispute would contain a record
    //of every user that disputes the "Copyright Date" field and the value that the 
    //user beleives is the accurate value.

    public class PrivateDispute
    {
        public String DisputedFieldName { get; private set; }
        public String _ReplacementValue { get; private set; }

        public PrivateDispute(String disputedFieldName, String _replacementValue)
        {
            if (String.IsNullOrWhiteSpace(disputedFieldName) || String.IsNullOrEmpty(disputedFieldName))
            {
                throw new ArgumentException("In class PrivateDispute, constructor.  Argument disputedFieldName cannot be null, an empty string, or white space.");
            }

            if (String.IsNullOrWhiteSpace(_replacementValue) || String.IsNullOrEmpty(_replacementValue))
            {
                throw new ArgumentException("In class PrivateDispute, constructor.  Argument _replacementValue cannot be null, an empty string, or white space.");
            }

            this.DisputedFieldName = disputedFieldName;
            this._ReplacementValue = _replacementValue.Trim().ToLower();
        }
    }
}
