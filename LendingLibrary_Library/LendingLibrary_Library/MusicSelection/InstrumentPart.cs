using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LendingLibrary_Library.MusicSelection;

namespace LendingLibrary_Library
{
    public class InstrumentPart
    {
        public Instrument _Instrument { get; private set; }
        public int NumberOfCopies { get; private set; }

        //When initializing a new InstrumentPart, be sure to catch both
        //ArgumentException and ArgumentNullException
        public InstrumentPart(Instrument instrument, int numberOfCopies)
        {
            if (instrument == null)
            {
                throw new ArgumentNullException("In InstrumentPart Class, constructor.  Argument instrument cannot be null.");
            }

            if (numberOfCopies < 0)
            {
                throw new ArgumentException("In InstrumentPart Class, constructor.  Argument numberOfCopies must be greater than zero.");
            }

            try
            {
                this._Instrument = instrument;
            }
            catch (ArgumentException ex)
            {
                throw ex;
            }
            this.NumberOfCopies = numberOfCopies;
        }

        public void setNumberOfCopies(int number)
        {
            if (number < 0)
            {
                throw new ArgumentException("In InstrumentPart Class, method setNumberOfCopies().  Argument number must be greater than zero.");
            }
            else
            {
                this.NumberOfCopies = number;
            }
        }
    }
}
