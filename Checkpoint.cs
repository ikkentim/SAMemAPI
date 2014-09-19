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
    public class Checkpoint : MemoryObject
    {
        public Checkpoint(ProcessMemory memory) : base(memory)
        {
        }

        [Address(0)]
        public byte TypeOfCheckpoint { get; set; }

        [Address(2)]
        public byte RGBAColorValue { get; set; }

        [Address(4)]
        public float X { get; set; }

        [Address(8)]
        public float Y { get; set; }

        [Address(12)]
        public float Z { get; set; }

        //+16 to +2//4 = [float] Rotation Matrix (direction from this checkpoint to the next, all floats)
        [Address(32)]
        public float CheckpointRadius { get; set; }
    }
}