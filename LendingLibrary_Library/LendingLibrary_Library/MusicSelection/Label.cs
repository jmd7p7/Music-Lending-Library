using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LendingLibrary_Library.MusicSelection
{
    public class Label
    {
        public String LabelName { get; private set; }
        public int Count { get; private set; }

        public Label(string labelName)
        {
            if (String.IsNullOrEmpty(labelName) || String.IsNullOrWhiteSpace(labelName))
            {
                throw new ArgumentException("Text must be provided for the label.");
            }

            this.LabelName = labelName.Trim();
            this.Count = 1;
        }

        public void IncrementCount()
        {
            this.Count++;
        }
        public void DecrementCount()
        {
            System.Diagnostics.Debug.Assert(this.Count != 0, 
                "Decrementing label count will result in a negative value.");
            this.Count--;
        }
    }
}
