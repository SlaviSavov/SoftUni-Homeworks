using System;
using System.Collections.Generic;
using System.Text;

namespace P04_Telephony.Exceptions
{
    public class InvalidURLException : Exception
    {
        private const string EXC_Message = "Invalid URL!";
        public InvalidURLException()
            :base(EXC_Message)
        {
        }

        public InvalidURLException(string message) 
            : base(message)
        {
        }
    }
}
