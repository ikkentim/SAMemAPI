using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SAMemAPI
{
    public class CVehiclePool : MemoryObject
    {
        public CVehiclePool(ProcessMemory memory)
            : base(memory)
        {
        }

        [Address(0)]
        public CVehicle FirstElement { get; set; }

        //+4 = Contains a pointer to a byte map indicating which elements are in use

        [Address(8)]
        public int MaxElements { get; set; }

        [Address(12)]
        public int Elements { get; set; }

        public CPed this[int i]
        {
            get { return new CPed(Memory.AtOffset(0).AsPointer() + (i * 0xA18)); }

        }
    }
}
