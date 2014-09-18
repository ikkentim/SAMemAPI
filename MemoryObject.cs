using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using SAMemAPI.Proxy;

namespace SAMemAPI
{
    [GameObject]
    public abstract class MemoryObject : ContextBoundObject
    {
        internal MemoryObject(ProcessMemory memory)
        {
            Memory = memory;
        }

        internal ProcessMemory Memory { get; set; }
    }
}
