using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LendingLibrary_Library.MusicSelection
{
    public class ChoralInstrumentPart : InstrumentPart
    {
        public Boolean IsInChoralScore { get; private set; }
        public ChoralInstrumentPart(String instrumentName, int numberOfCopies, Boolean isInChoralScore)
            : base(instrumentName, numberOfCopies)
        {
            this.IsInChoralScore = isInChoralScore;
        }

        public override bool Equals(object obj)
        {
            // If parameter is null return false.
            if (obj == null)
            {
                return false;
            }

            // If parameter cannot be cast to Tag return false.
            ChoralInstrumentPart instrumentPart = obj as ChoralInstrumentPart;
            if ((System.Object)instrumentPart == null)
            {
                return false;
            }

            return (this.InstrumentName == instrumentPart.InstrumentName) && 
                   (this.NumberOfCopies == instrumentPart.NumberOfCopies) &&
                   (this.IsInChoralScore == instrumentPart.IsInChoralScore);
        }

        public override int GetHashCode()
        {
            //John Skeet's implementation of GetHashCode()
            //http://stackoverflow.com/questions/263400/what-is-the-best-algorithm-for-an-overridden-system-object-gethashcode/263416#263416

            unchecked // Overflow is fine, just wrap
            {
                int hash = 17;
                hash = this.InstrumentName == null ? hash : hash * 23 + this.InstrumentName.GetHashCode();
                hash = this.NumberOfCopies == null ? hash : hash * 23 + this.NumberOfCopies.GetHashCode();
                hash = this.IsInChoralScore == null ? hash : hash * 23 + this.IsInChoralScore.GetHashCode();
                return hash;
            }
        }
    }
}
