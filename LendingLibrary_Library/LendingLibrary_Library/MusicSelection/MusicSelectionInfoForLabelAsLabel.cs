using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LendingLibrary_Library.MusicSelection
{
    public class MusicSelectionInfoForLabelAsLabel
    {
        public String MusicSelectionId { get; private set; }
        public String MusicSelectionName { get; private set; }
        public String ComposerName { get; private set; }
        public Boolean IsChoral { get; private set; }
        public int Count { get; private set; }

        public MusicSelectionInfoForLabelAsLabel(MusicSelectionDetailsProvider infoProvider, Boolean isChoral)
        {
            this.MusicSelectionId = infoProvider.getMusicSelectionId();
            this.MusicSelectionName = infoProvider.getMusicSelectionName();
            this.ComposerName = infoProvider.getComposerName();
            this.IsChoral = isChoral;
            this.Count = 1;
        }

        public void IncrementCount()
        {
            this.Count++;
        }

        public void DecrementCount()
        {
            if (Count == 0)
            {
                throw new InvalidOperationException("In class MusicSelectionForLabelAsLabel, method DecrementCount().  Cannot decrement field Count when Count is currently zero.");
            }
            this.Count--;
        }

    }
}
