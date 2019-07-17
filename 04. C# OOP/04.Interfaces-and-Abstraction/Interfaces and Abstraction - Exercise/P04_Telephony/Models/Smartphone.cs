using P04_Telephony.Contracts;
using P04_Telephony.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace P04_Telephony.Models
{
    public class Smartphone : ICallable, IBrowseable
    {
        public Smartphone()
        {

        }
        public string Browse(string url)
        {
            if (url.Any(c=>char.IsDigit(c)))
            {
                throw new InvalidURLException();
            }
            return $"Browsing: {url}!";
        }

        public string Call(string phoneNumber)
        {
            if (!phoneNumber.All(c=>Char.IsDigit(c)))
            {
                throw new InvalidPhoneNumberException();
            }
            return $"Calling... {phoneNumber}";
        }
    }
}
