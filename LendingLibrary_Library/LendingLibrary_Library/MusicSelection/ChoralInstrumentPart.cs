using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LendingLibrary_Library.MusicSelection
{
    public class ChoralInstrumentPart : InstrumentPart
    {
        public Boolean IsIncludedInChoralScore { get; private set; }
        public ChoralInstrumentPart(Instrument instrument, int numberOfCopies, Boolean isIncludedInChoralScore)
            : base(instrument, numberOfCopies)
        {
            this.IsIncludedInChoralScore = isIncludedInChoralScore;
        }
    }
}
