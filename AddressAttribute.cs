using System;

namespace SAMemAPI
{
    [AttributeUsage(AttributeTargets.Property)]
    class AddressAttribute : Attribute
    {
        public int Address { get; private set; }

        public int Length { get; private set; }

        public AddressAttribute(int address)
        {
            Address = address;
            Length = 4;
        }
        public AddressAttribute(int address, int length)
        {
            Address = address;
            Length = length;
        }
    }
}
