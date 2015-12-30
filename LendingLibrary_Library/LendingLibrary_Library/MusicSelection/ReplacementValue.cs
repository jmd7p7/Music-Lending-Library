using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LendingLibrary_Library.MusicSelection
{
    public class ReplacementValue
    {
        public String _ReplacementValue { get; private set; }
        private List<String> InstitutionIds;

        public ReplacementValue(String replacementValue, String institutionId)
        {
            if (String.IsNullOrWhiteSpace(replacementValue) || String.IsNullOrEmpty(replacementValue))
            {
                throw new ArgumentException("In class ReplacementValue, constructor. The replacement value must contain text.");
            }
            if (String.IsNullOrEmpty(institutionId) || String.IsNullOrWhiteSpace(institutionId))
            {
                throw new ArgumentException("In class ReplacementValue, constructor. The InstituionId must contain characters.");
            }
            Debug.Assert(24 == institutionId.Length, "In class ReplacementValue, constructor. Attempted to add an institutionId (objectId) that was not 24 characters long to a replacement value.");

            this._ReplacementValue = replacementValue.Trim();
            this.InstitutionIds = new List<string>() { institutionId };
        }

        public void AddInsitutionId(String institutionId)
        {
            Debug.Assert(24 == institutionId.Length, "In class ReplacementValue, AddInsitutionId(). Attempted to add an institutionId (objectId) that was not 24 characters long to a replacement value.");

            if (this.InstitutionIds.Contains(institutionId))
            {
                throw new ArgumentException("In class ReplacementValue, AddInsitutionId(). Attempted to add an institutionId that already exists in the list.");
            }

            this.InstitutionIds.Add(institutionId);
        }

        public void RemoveInstituionId(String institutionId)
        {
            Debug.Assert(24 == institutionId.Length, "In class ReplacementValue, RemoveInsitutionId(). Attempted to remove an institutionId (objectId) that was not 24 characters long from a replacement value.");

            if (this.InstitutionIds.Count == 0)
            {
                throw new ArgumentException("In class ReplacementValue, RemoveInsitutionId(). Attempted to remove an institutionId (objectId) from a replacement value that has zero institutionIds.");
            }

            if (!this.InstitutionIds.Contains(institutionId))
            {
                throw new ArgumentException("In class ReplacementValue, RemoveInsitutionId(). Attempted to remove an institutionId (objectId) from a replacement value where that institutionId does not exist.");
            }

            this.InstitutionIds.Remove(institutionId);
        }

        public System.Collections.ObjectModel.ReadOnlyCollection<String> getInsitutionIds()
        {
            return this.InstitutionIds.AsReadOnly();
        }

        public int getCount()
        {
            return this.InstitutionIds.Count;
        }
    }
}
