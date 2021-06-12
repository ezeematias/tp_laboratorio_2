using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exceptions
{
    class ExceptionFiles : Exception
    {
        public ExceptionFiles() : this("ERROR FILE")
        {
        }

        public ExceptionFiles(Exception innerException)
            : this(innerException, String.Format("ERROR FILE: {0}", innerException.Message))
        {
        }

        public ExceptionFiles(string msg) : this(null, msg)
        {
        }

        public ExceptionFiles(Exception innerException, string msg)
            : base(msg, innerException)
        {
        }
    }
}
