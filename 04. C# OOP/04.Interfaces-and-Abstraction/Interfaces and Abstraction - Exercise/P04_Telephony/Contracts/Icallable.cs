using System;
using System.Collections.Generic;
using System.Text;

namespace P04_Telephony.Contracts
{
    public interface ICallable
    {
        string Call(string phoneNumber);
    }
}
