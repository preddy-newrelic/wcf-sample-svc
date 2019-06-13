﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace ArupConsoleService
{
    [DataContract]
    public class ApplicationException : Exception
    {
        public ApplicationException()
        {
        }
        
        public ApplicationException(string message)
            : base(message)
        {
        }

        public ApplicationException(string message, Exception inner)
            : base(message, inner)
        {
        }
    }
}
