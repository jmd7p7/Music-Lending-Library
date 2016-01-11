using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LendingLibrary_Library.Utility
{
    public static class ErrorChecking
    {
        public static void CheckStringForNullEmptyOrWhiteSpace_ThrowException(string argument)
        {
            if (argument == null)
            {
                throw new ArgumentNullException("String argument cannot be null.");
            }
            if (argument == "")
            {
                throw new ArgumentException("String argument cannot be empty.");
            }
            if (String.IsNullOrWhiteSpace(argument))
            {
                throw new ArgumentException("String argument cannot be white space.");
            }
        }

        public static Boolean CheckStringForNullEmptyOrWhiteSpace(string argument)
        {
            if (argument == null)
            {
                return true;
            }
            if (argument == "")
            {
                return true;
            }
            if (String.IsNullOrWhiteSpace(argument))
            {
                return true;
            }
            return false;
        }

        public static void CheckObjectForNull(Object obj)
        {
            if (obj == null)
            {
                throw new ArgumentNullException("The object argument cannot be null.");
            }
        }
    }
}
