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