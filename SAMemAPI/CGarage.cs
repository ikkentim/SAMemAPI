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
    public class CGarage : MemoryObject
    {
        public CGarage(ProcessMemory memory) : base(memory)
        {
        }

        [Address(0)]
        public float XCoordOfTheGarageLowerLeftCorner { get; set; }

        [Address(4)]
        public float YCoordOfTheGarageLowerLeftCorner { get; set; }

        [Address(8)]
        public float ZCoordOfTheGarageLowerLeftCorner { get; set; }

        [Address(12)]
        public float XValueOfDirectionVector1 { get; set; }

        [Address(16)]
        public float YValueOfDirectionVector1 { get; set; }

        [Address(20)]
        public float XValueOfDirectionVector2 { get; set; }

        [Address(24)]
        public float YValueOfDirectionVector2 { get; set; }

        [Address(28)]
        public float TopZCoordOfTheGarage { get; set; }

        [Address(32)]
        public float NormalizedWidthOfTheGarage { get; set; }

        [Address(36)]
        public float NormalizedDepthOfTheGarage { get; set; }

        [Address(40)]
        public float LeftBorderCorrdinate { get; set; }

        [Address(44)]
        public float RightBorderCorrdinate { get; set; }

        [Address(48)]
        public float FrontBorderCorrdinate { get; set; }

        [Address(52)]
        public float BackBorderCorrdinate { get; set; }

        [Address(56)]
        public float GarageDoorPosition { get; set; }

        [Address(60)]
        public int Unknown1 { get; set; }

        [Address(64)]
        public int Unknown2 { get; set; }

        [Address(68)]
        public int GarageName { get; set; }

        [Address(76)]
        public byte GarageType { get; set; }

        [Address(77)]
        public byte GarageDoorStateValues { get; set; }

        /*
        0 = closed
        1 = open
        2 = closing
        3 = opening*/

        [Address(78)]
        public byte DoorFlags { get; set; }

        /*
        0x01 = used mod shop (?)
        0x02 = inactive door
        0x04 = used Pay'n'Spray (?)
        0x08 = small door (reflective?)
        0x10 = up and in door
        0x20 = camera follows player
        0x40 = door is closed flag
        0x80 = girlfriend PnS*/

        [Address(79)]
        public byte OriginalType { get; set; }
    }
}