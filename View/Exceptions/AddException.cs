using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace View.Exceptions
{
    [Serializable]
    public class AddException : Exception
    {
        public AddException()
        {
        }

        public AddException(string message) : base(message)
        {
        }
    }
}
