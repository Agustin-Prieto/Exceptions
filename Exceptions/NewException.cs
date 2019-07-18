using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Exceptions
{
    class NewException : Exception
    {
        public NewException()
        {
        }

        public NewException(string message) : base("Excepción personalizada")
        {
        }

        public NewException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected NewException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}
