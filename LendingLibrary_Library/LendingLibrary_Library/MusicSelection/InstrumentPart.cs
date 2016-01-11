using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LendingLibrary_Library.MusicSelection
{
    public class InstrumentPart
    {
        public String InstrumentName { get; private set; }
        public String InstrumentName_LowerCase { get; private set; }
        public int NumberOfCopies { get; private set; }

        public InstrumentPart(String instrumentName, int numberOfCopies)
        {
            if (instrumentName == null)
            {
                throw new ArgumentNullException("In class InstrumentPart, constructor.  String argument instrumentName cannot be null.");
            }
            if (instrumentName == "")
            {
                throw new ArgumentException("In class InstrumentPart, constructor.  String argument instrumentName cannot be empty.");
            }
            if (String.IsNullOrWhiteSpace(instrumentName))
            {
                throw new ArgumentException("In class InstrumentPart, constructor.  String argument instrumentName cannot be white space.");
            }
            if (numberOfCopies < 0)
            {
                throw new ArgumentException("In class InstrumentPart, constructor.  Int argument numberOfCopies cannot be less than zero.");
            }

            this.InstrumentName = instrumentName.Trim();
            this.InstrumentName_LowerCase = instrumentName.Trim().ToLower();
            this.NumberOfCopies = numberOfCopies;
        }
    }
}
