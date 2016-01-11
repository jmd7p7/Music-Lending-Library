using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LendingLibrary_Library.Utility;

namespace LendingLibrary_Library.Utility
{
    public class Name
    {
        public String FirstName { get; private set; }
        public String FirtName_LowerCase { get; private set; }
        public String MiddleName { get; private set; }
        public String MiddleName_LowerCase { get; private set; }
        public String LastName { get; private set; }
        public String LastName_LowerCase { get; private set; }
        public String Prefix { get; private set; }
        public String Prefix_LowerCase { get; private set; }
        public String Suffix { get; private set; }
        public String Suffix_LowerCase { get; private set; }

        public Name(String firstName, String middleName, String lastName, String prefix = "", String suffix = "")
        {
            try
            {
                ErrorChecking.CheckStringForNullEmptyOrWhiteSpace_ThrowException(lastName);
            }
            catch (ArgumentNullException ex)
            {
                throw new ArgumentNullException("In class Name, lastName only constructor. " + ex.Message);
            }
            catch (ArgumentException ex)
            {
                throw new ArgumentException("In class Name, lastName only constructor. " + ex.Message);
            }

            this.LastName = lastName.Trim();
            this.LastName_LowerCase = lastName.Trim().ToLower();
            this.FirstName = ErrorChecking.CheckStringForNullEmptyOrWhiteSpace(firstName) == true ? "" : firstName.Trim();
            this.FirtName_LowerCase = ErrorChecking.CheckStringForNullEmptyOrWhiteSpace(firstName) == true ? "" : firstName.Trim().ToLower();
            this.MiddleName = ErrorChecking.CheckStringForNullEmptyOrWhiteSpace(middleName) == true ? "" : middleName.Trim();
            this.MiddleName_LowerCase = ErrorChecking.CheckStringForNullEmptyOrWhiteSpace(middleName) == true ? "" : middleName.Trim().ToLower();
            this.Prefix = ErrorChecking.CheckStringForNullEmptyOrWhiteSpace(prefix) == true ? "" : prefix.Trim();
            this.Prefix_LowerCase = ErrorChecking.CheckStringForNullEmptyOrWhiteSpace(prefix) == true ? "" : prefix.Trim().ToLower();
            this.Suffix = ErrorChecking.CheckStringForNullEmptyOrWhiteSpace(suffix) == true ? "" : suffix.Trim();
            this.Suffix_LowerCase = ErrorChecking.CheckStringForNullEmptyOrWhiteSpace(suffix) == true ? "" : suffix.Trim().ToLower();
        }

        public String getFullName()
        {
            String result = "";
            result = this.Prefix == "" ? result : result + this.Prefix + " ";
            result = this.FirstName == "" ? result : result + this.FirstName + " ";
            result = this.MiddleName == "" ? result : result + this.MiddleName + " ";
            result = result + this.LastName;
            result = this.Suffix == "" ? result : result + " " + this.Suffix;
            return result;
        }

        public String getFullName_LowerCase()
        {
            return getFullName().ToLower();
        }

        public override bool Equals(object obj)
        {
            // If parameter is null return false.
            if (obj == null)
            {
                return false;
            }

            // If parameter cannot be cast to Tag return false.
            Name name = obj as Name;
            if ((System.Object)name == null)
            {
                return false;
            }

            return (
                    this.FirstName == name.FirstName && 
                    this.FirtName_LowerCase == name.FirtName_LowerCase &&
                    this.LastName == name.LastName && 
                    this.LastName_LowerCase == name.LastName_LowerCase &&
                    this.MiddleName == name.MiddleName &&
                    this.MiddleName_LowerCase == name.MiddleName_LowerCase &&
                    this.Prefix == name.Prefix && 
                    this.Prefix_LowerCase == name.Prefix_LowerCase &&
                    this.Suffix == name.Suffix && 
                    this.Suffix_LowerCase == name.Suffix_LowerCase
                );
        }

        public override int GetHashCode()
        {
            //John Skeet's implementation of GetHashCode()
            //http://stackoverflow.com/questions/263400/what-is-the-best-algorithm-for-an-overridden-system-object-gethashcode/263416#263416

            unchecked // Overflow is fine, just wrap
            {
                int hash = 17;
                hash = this.FirstName == null ? hash : hash * 23 + this.FirstName.GetHashCode();
                hash = this.LastName == null ? hash : hash * 23 + this.LastName.GetHashCode();
                hash = this.MiddleName == null ? hash : hash * 23 + this.MiddleName.GetHashCode();
                hash = this.Prefix == null ? hash : hash * 23 + this.Prefix.GetHashCode();
                hash = this.Suffix == null ? hash : hash * 23 + this.Suffix.GetHashCode();
                return hash;
            }
        }
    }
}
