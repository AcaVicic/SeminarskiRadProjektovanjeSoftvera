using System;
using System.Collections.Generic;
using System.Text;

namespace View.Exceptions
{
    public class LoginException : Exception
    {
        public LoginException()
        {

        }
        public LoginException(string message) : base(message)
        {

        }
    }
}
