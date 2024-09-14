using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHandling
{
    internal class YouTubeException : Exception
    {
        public YouTubeException(string message, Exception innerException) : base(message, innerException)
        {
        }
    }
}
