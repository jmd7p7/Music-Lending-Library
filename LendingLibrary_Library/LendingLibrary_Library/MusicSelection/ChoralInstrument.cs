using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LendingLibrary_Library.MusicSelection
{
    public class ChoralInstrument : Instrument
    {
        public Boolean IsIncludedInChoralScore { get; private set; }
        public ChoralInstrument(String instrumentName, Boolean createdByAdministrator, Boolean isIncludedInChoralScore)
            : base(instrumentName, createdByAdministrator)
        {
            this.IsIncludedInChoralScore = isIncludedInChoralScore;
        }
    }
}
