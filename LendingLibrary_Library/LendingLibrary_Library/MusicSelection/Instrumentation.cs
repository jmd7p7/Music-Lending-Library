using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LendingLibrary_Library.MusicSelection
{
    public class Instrumentation
    {
        public String InstrumentationName { get; private set; }
        public Boolean Approved { get; private set; }
        public int NumberOfTimesUsed { get; private set; }
        private static int APPROVAL_THRESHOLD = 50;

        public Instrumentation(String instrumentationName, Boolean createdByAdministrator)
        {
            if (String.IsNullOrEmpty(instrumentationName) || String.IsNullOrWhiteSpace(instrumentationName))
            {
                throw new ArgumentException("In class Instrumentation, constructor.  Argument instrumentationName cannot be null, empty string, or white space.");
            }

            this.InstrumentationName = instrumentationName.Trim().ToLower();
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
