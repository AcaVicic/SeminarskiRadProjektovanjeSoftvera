using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace View.Exceptions
{
    public class FindException : Exception
    {
        public FindException()
        {
        }

        public FindException(string message) : base(message)
        {
        }
    }
}
