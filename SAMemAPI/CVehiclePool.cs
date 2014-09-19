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
    public class CVehiclePool : Pool<CVehicle>
    {
        public CVehiclePool(ProcessMemory memory)
            : base(memory, 0xA18, 0)
        {
        }

        [Address(0)]
        public CVehicle FirstElement { get; set; }

        //+4 = Contains a pointer to a byte map indicating which elements are in use

        public override int Length
        {
            get { return MaxElements; }
            protected set { }
        }

        [Address(8)]
        private int MaxElements { get; set; }

        [Address(12)]
        private int Elements { get; set; }

        public override CVehicle this[int i]
        {
            get
            {
                // TODO: Map index using +4 bytemap

                //FirstElement + Offset
                return new CVehicle(Memory.AtOffset(0).AsPointer() + (i*BlockSize));
            }
        }
    }
}