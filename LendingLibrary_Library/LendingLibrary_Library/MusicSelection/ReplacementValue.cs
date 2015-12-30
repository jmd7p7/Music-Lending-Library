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

            this._ReplacementValue = replacementValue.Trim().ToLower();
            this.InstitutionIds = new List<string>() { institutionId };
        }

        public void AddInsitutionId(String institutionId)
        {         
            if (this.InstitutionIds.Contains(institutionId))
            {
                throw new ArgumentException("In class ReplacementValue, AddInsitutionId(). Attempted to add an institutionId that already exists in the list.");
            }

            this.InstitutionIds.Add(institutionId);
        }

        public void RemoveInstituionId(String institutionId)
        {         
            if (this.InstitutionIds.Count == 0)
            {
                throw new ArgumentException("In class ReplacementValue, RemoveInsitutionId(). Attempted to remove an institutionId (objectId) from a replacement value that has zero institutionIds.");
            }

            if (this.InstitutionIds.Contains(institutionId) == false)
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

        public override bool Equals(Object obj)
        {
            // Check for null values and compare run-time types.
            if (obj == null || GetType() != obj.GetType())
                return false;

            ReplacementValue given = (ReplacementValue)obj;
            if (this._ReplacementValue == given._ReplacementValue)
            {
                return Enumerable.SequenceEqual(this.InstitutionIds, given.InstitutionIds);
            }
            return false;
        }
    }
}
