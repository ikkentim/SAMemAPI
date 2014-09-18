namespace SAMemAPI
{
    public class PlayerPosition : MemoryObject
    {
        public PlayerPosition(ProcessMemory memory) : base(memory)
        {
        }

        //(CPed+0x14) +0x0 to +0x2C = [dword] Is the rotation matrix

        [Address(0x30)]
        public float X { get; set; }

        [Address(0x34)]
        public float Y { get; set; }

        [Address(0x38)]
        public float Z { get; set; }
    }
}