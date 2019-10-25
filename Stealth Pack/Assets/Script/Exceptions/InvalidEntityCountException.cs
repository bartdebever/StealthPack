using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assets.Script.Exceptions
{
    [Serializable]
    public class InvalidEntityCountException : Exception
    {
        public InvalidEntityCountException() : base()
        {
        }

        public InvalidEntityCountException(string message) : base(message)
        {
        }

        public InvalidEntityCountException(string message, Exception exception) : base(message, exception)
        {
        }
    }
}
