using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LendingLibrary_Library.MusicSelection
{
    public class Instrument
    {
        public String InstrumentName { get; private set; }
        public Boolean Approved { get; private set; }
        public int NumberOfTimesUsed { get; private set; }

        private static int APPROVAL_THRESHOLD = 50;

        public Instrument(String instrumentName, Boolean createdByAdministrator)
        {
            if (String.IsNullOrWhiteSpace(instrumentName) || String.IsNullOrEmpty(instrumentName))
            {
                throw new ArgumentException("In class InstrumentName, constructor.  Argument instrumentName cannot be null, white space, or empty.");
            }

            this.InstrumentName = instrumentName.Trim().ToLower();
            if (createdByAdministrator)
            {
                this.Approved = true;
                this.NumberOfTimesUsed = 0;
            }
            else
            {
                this.Approved = false;
                this.NumberOfTimesUsed = 1;
            }
        }

        public void IncrementNumberOfTimesUsed()
        {
            this.NumberOfTimesUsed++;
            this.Approved = this.NumberOfTimesUsed >= APPROVAL_THRESHOLD ? true : this.Approved;
        }
    }
}
