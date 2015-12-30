using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LendingLibrary_Library.MusicSelection
{
    //See the comments in the class PrivateDispute to understand the
    //difference between a dispute and a private dispute
    public class Dispute
    {
        public String DisputedFieldName { get; private set; }
        
        //private Dictionary<String, ReplacementValue> ReplacementValues;

        //New Code
        private List<ReplacementValue> _ReplacementValues;

        public ReadOnlyCollection<ReplacementValue> getReplacementValues()
        {
            return this._ReplacementValues.AsReadOnly();
        }

        public Dispute(String disputedFieldName, String replacementValue, String institutionId)
        {

            if(String.IsNullOrWhiteSpace(disputedFieldName) || String.IsNullOrEmpty(disputedFieldName))
            {
                throw new ArgumentException("In class Dispute, constructor.  DisputedFieldName argument must have text.");
            }

            if (String.IsNullOrWhiteSpace(replacementValue) || String.IsNullOrEmpty(replacementValue))
            {
                throw new ArgumentException("In class Dispute, constructor.  ReplacementValue argument must have text.");
            }

            if (String.IsNullOrWhiteSpace(institutionId) || String.IsNullOrEmpty(institutionId))
            {
                throw new ArgumentException("In class Dispute, constructor.  InstitudionId argument must have text.");
            }
        

            this.DisputedFieldName = disputedFieldName;
            String formattedReplacementValue = replacementValue.Trim().ToLower();

            //old Code
            //try
            //{
            //    this.ReplacementValues = new Dictionary<string, ReplacementValue>()
            //    {
            //        { formattedReplacementValue, new ReplacementValue(formattedReplacementValue, institutionId) }
            //    };
            //}
            //catch (ArgumentException ex)
            //{
            //    throw ex;
            //}

            //new code
            try
            {
                this._ReplacementValues = new List<ReplacementValue>()
                {
                    new ReplacementValue(formattedReplacementValue, institutionId)
                };
            }
            catch (ArgumentException ex)
            {
                throw ex;
            }
        }

        
        public void UpdateUserReplacementValue(String newReplacementValue, String oldReplacementValue, String institutionId)
        {        
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



            //if (this.ReplacementValues.Keys.Contains(formattedOldReplacementValue) == false)
            //{
            //    throw new ArgumentException("In Dispute, AddNewReplacementvalue_RemoveOld().  The oldReplacementValue does not exist.");
            //}

            //try
            //{
            //    this.ReplacementValues[formattedOldReplacementValue].RemoveInstituionId(institutionId);
                
            //    if (this.ReplacementValues.Keys.Contains(formattedNewReplacementValue))
            //    {
            //        this.ReplacementValues[formattedNewReplacementValue].AddInsitutionId(institutionId);
            //    }
            //    else
            //    {
            //        this.ReplacementValues.Add(formattedNewReplacementValue, 
            //            new ReplacementValue(formattedNewReplacementValue, institutionId));
            //    }
            //}
            //catch (ArgumentException ex)
            //{
            //    throw ex;
            //}

            //New Code
            String formattedOldReplacementValue = oldReplacementValue.Trim().ToLower();
            String formattedNewReplacementValue = newReplacementValue.Trim().ToLower();

            if (_ReplacementValues.Exists(r => r._ReplacementValue == formattedOldReplacementValue) == false)
            {
                throw new ArgumentException("In Dispute, AddNewReplacementvalue_RemoveOld().  The oldReplacementValue does not exist.");
            }

            try
            {
                _ReplacementValues.Single(r => r._ReplacementValue == formattedOldReplacementValue).RemoveInstituionId(institutionId);
                if (_ReplacementValues.Exists(r => r._ReplacementValue == formattedNewReplacementValue))
                {
                    _ReplacementValues.Single(r => r._ReplacementValue == formattedNewReplacementValue).AddInsitutionId(institutionId);
                }
                else
                {
                    _ReplacementValues.Add(new ReplacementValue(formattedNewReplacementValue, institutionId));
                }
            }
            catch (ArgumentException ex)
            {
                throw ex;
            }
        }

        public void AddUserReplacementvalue(String replacementValue, String institutionId)
        {
            if (String.IsNullOrEmpty(replacementValue) || String.IsNullOrWhiteSpace(replacementValue))
            {
                throw new ArgumentException("In Class Dispute, AddNewReplacementValue().  String arguement replacementValue cannot be null, empty, or white space.");
            }

            if (String.IsNullOrEmpty(institutionId) || String.IsNullOrWhiteSpace(institutionId))
            {
                throw new ArgumentException("In Class Dispute, AddNewReplacementValue().  String arguement institutionId cannot be null, empty, or white space.");
            }
        

            String formattedReplacementValue = replacementValue.Trim().ToLower();
            //if (this.ReplacementValues.Keys.Contains(formattedReplacementValue))
            //{
            //    this.ReplacementValues[formattedReplacementValue].AddInsitutionId(institutionId);
            //}
            //else
            //{
            //    this.ReplacementValues.Add(formattedReplacementValue, 
            //        new ReplacementValue(formattedReplacementValue, institutionId));
            //}

            //new code
            try
            {
                if (_ReplacementValues.Exists(r => r._ReplacementValue == formattedReplacementValue))
                {
                    this._ReplacementValues.Single(r => r._ReplacementValue == formattedReplacementValue).AddInsitutionId(institutionId);
                }
                else
                {
                    this._ReplacementValues.Add(new ReplacementValue(formattedReplacementValue, institutionId));
                }
            }
            catch (ArgumentException ex)
            {
                throw ex;
            }
        }
    }
}
