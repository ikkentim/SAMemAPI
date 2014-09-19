// SAMemAPI
// Copyright (C) 2014 Tim Potze
// 
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND,
// EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF
// MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT.
// IN NO EVENT SHALL THE AUTHORS BE LIABLE FOR ANY CLAIM, DAMAGES OR
// OTHER LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE,
// ARISING FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR
// OTHER DEALINGS IN THE SOFTWARE.
// 
// For more information, please refer to <http://unlicense.org>

namespace SAMemAPI
{
    public class Rocket : MemoryObject
    {
        public Rocket(ProcessMemory memory) : base(memory)
        {
        }

        [Address(0)]
        public int RocketType { get; set; }

/*
16 = none
17 = tear gas
19 = normal
20 = heatseeking
39 = remote explosives
58 = flare*/

        [Address(4)]
        public int PointerToLaunchingEntity { get; set; }

        [Address(8)]
        public int PointerToTargetVehicle0Otherwise { get; set; }

        [Address(16)]
        public byte DoesRocketExist { get; set; }

        /*
0 = exploded/does not exist
1 = travelling*/

        [Address(20)]
        public float X { get; set; }

        [Address(24)]
        public float Y { get; set; }

        [Address(28)]
        public float Z { get; set; }
    }
}