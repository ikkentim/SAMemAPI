using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SAMemAPI
{
    public class VehiclePosition : MemoryObject
    {
        public VehiclePosition(ProcessMemory memory) : base(memory)
        {
        }

        [Address(0)]
        public float XRotation { get; set; }

        [Address(4)]
        public float YRotation { get; set; }

        [Address(8)]
        public float ZRotation { get; set; }

        [Address(16)]
        public float XRotationLooking { get; set; }

        [Address(20)]
        public float YRotationLooking { get; set; }

        [Address(24)]
        public float ZRotationLooking { get; set; }

        [Address(48)]
        public float X { get; set; }

        [Address(52)]
        public float Y { get; set; }

        [Address(56)]
        public float Z { get; set; }

    }
}
