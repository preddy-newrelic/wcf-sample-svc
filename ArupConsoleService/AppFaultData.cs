using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace ArupConsoleService
{
    [DataContract]
    public class AppFaultData
    {
        [DataMember]
        public int ErrorCode { get; set; }
    }
}
