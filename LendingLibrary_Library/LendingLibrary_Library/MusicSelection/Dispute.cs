using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LendingLibrary_Library.MusicSelection
{
    public class Dispute
    {
        public String DisputedFieldName { get; private set; }
        public Dictionary<String, ReplacementValue> ReplacementValues { get; private set; }

        public Dispute(String disputedFieldName, String replacementValue, String institutionId)
        {
            Debug.Assert(24 == institutionId.Length, "In class Dispute, constructor. Attempted to add an institutionId (objectId) that was not 24 characters long to a dispute.");

            if(String.IsNullOrWhiteSpace(disputedFieldName) || String.IsNullOrEmpty(disputedFieldName))
            {
                throw new ArgumentException("In Dispute, constructor.  DisputedFieldName argument must have text.");
            }

            if (String.IsNullOrWhiteSpace(replacementValue) || String.IsNullOrEmpty(replacementValue))
            {
                throw new ArgumentException("In Dispute, constructor.  ReplacementValue argument must have text.");
            }

            if (String.IsNullOrWhiteSpace(institutionId) || String.IsNullOrEmpty(institutionId))
            {
                throw new ArgumentException("In Dispute, constructor.  InstitudionId argument must have text.");
            }

            this.DisputedFieldName = disputedFieldName;
            try
            {
                this.ReplacementValues = new Dictionary<string, ReplacementValue>()
                {
                    { replacementValue, new ReplacementValue(replacementValue, institutionId) }
                };
            }
            catch (ArgumentException ex)
            {
                throw ex;
            }
        }

        public void AddNewReplacementvalue_RemoveOld(String newReplacementValue, String oldReplacementValue, String institutionId)
        {
            Debug.Assert(24 == institutionId.Length, "In class Dispute, AddNewReplacementvalue_RemoveOld(). Attempted to add an institutionId (objectId) that was not 24 characters long to a dispute.");

            if (String.IsNullOrWhiteSpace(newReplacementValue) || String.IsNullOrEmpty(newReplacementValue))
            {
                throw new ArgumentException("In Dispute, AddNewReplacementvalue_RemoveOld().  NewReplacementValue argument must have text.");
            }

            if (String.IsNullOrWhiteSpace(oldReplacementValue) || String.IsNullOrEmpty(oldReplacementValue))
            {
                throw new ArgumentException("In Dispute, AddNewReplacementvalue_RemoveOld().  OldReplacementValue argument must have text.");
            }

            if (String.IsNullOrWhiteSpace(institutionId) || String.IsNullOrEmpty(institutionId))
            {
                throw new ArgumentException("In Dispute, AddNewReplacementvalue_RemoveOld().  InstitutionId argument must have text.");
            }

            try
            {
                this.ReplacementValues[oldReplacementValue].RemoveInstituionId(institutionId);

                if (this.ReplacementValues.Keys.Contains(newReplacementValue))
                {
                    this.ReplacementValues[newReplacementValue].AddInsitutionId(institutionId);
                }
                else
                {
                    this.ReplacementValues.Add(newReplacementValue, new ReplacementValue(newReplacementValue, institutionId));
                }
            }
            catch (ArgumentException ex)
            {
                throw ex;
            }
        }
    }
}
