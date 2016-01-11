using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LendingLibrary_Library.Utility;

namespace LendingLibrary_Library.MusicSelection
{
    public class Contributor
    {
        private Name ContributorName;
        public String Role { get; private set; }
        public String Role_LowerCase { get; private set; }

        public Contributor(Name contributorName, String role)
        {
            if (contributorName == null)
                throw new ArgumentNullException("In class Contributor, constructor.  The argument contrubtorName cannot be null.");

            if (role == null)
                throw new ArgumentNullException("In class contributor, constructor.  The String argument role cannot be null.");

            if (role == "")
                throw new ArgumentException("In class contributor, constructor.  The String argument role cannot be an empty string.");

            if (String.IsNullOrWhiteSpace(role))
                throw new ArgumentException("In class contributor, constructor.  The String argument role cannot be white space.");

            this.ContributorName = contributorName;
            this.Role = role.Trim();
            this.Role_LowerCase = role.Trim().ToLower();
        }

        public Contributor(Boolean unknown, Boolean anonymous)
        {
            if (unknown == anonymous)
            {
                throw new ArgumentException("In class Contribtor, constructor.  Boolean arguments unknown and anonymous cannot both be true or both be false.");
            }
            this.ContributorName = unknown == true ? new Name("", "", "unknown") : new Name("", "", "anonymous");

            //Each music selection MUST have a composer associated with it.  However, sometimes the composer's name is in fact unknown
            //or anonymous.  That being said, the only Role that can take on the values of unknown or anonymous is composer.
            this.Role = "Composer";
            this.Role_LowerCase = "composer";
        }

        public String getFullName()
        {
            return this.ContributorName.getFullName();
        }

        public String getFullName_LowerCase()
        {
            return this.ContributorName.getFullName_LowerCase();
        }

        public override bool Equals(Object obj)
        {
            // If parameter is null return false.
            if (obj == null)
            {
                return false;
            }

            // If parameter cannot be cast to Contributor return false.
            Contributor con = obj as Contributor;
            if ((System.Object)con == null)
            {
                return false;
            }

            // Return true if the fields match:
            return (this.ContributorName.Equals(con.ContributorName)) && 
                   (this.Role == con.Role) && 
                   (this.Role_LowerCase == con.Role_LowerCase);
        }

        public override int GetHashCode()
        {
            //John Skeet's implementation of GetHashCode()
            //http://stackoverflow.com/questions/263400/what-is-the-best-algorithm-for-an-overridden-system-object-gethashcode/263416#263416

            unchecked // Overflow is fine, just wrap
            {
                int hash = 17;
                hash = this.ContributorName == null ? hash : hash * 23 + this.ContributorName.GetHashCode();
                hash = this.Role == null ? hash : hash * 23 + this.Role.GetHashCode();
                return hash;
            }
        }
    }
}
