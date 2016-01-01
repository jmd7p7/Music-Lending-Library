using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LendingLibrary_Library.MusicSelection
{
    public interface MusicSelectionDetailsProvider
    {
        String getMusicSelectionId();
        String getComposerName();
        String getMusicSelectionName();
    }
}
