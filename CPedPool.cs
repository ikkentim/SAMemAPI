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

using SAMemAPI;

public class CPedPool : MemoryObject
{
    public CPedPool(ProcessMemory memory) : base(memory)
    {
    }

    [Address(0)]
    public CPed FirstElement { get; set; }

    //+4 = Contains a pointer to a byte map indicating which elements are in use

    [Address(8)]
    public int MaxElements { get; set; }

    [Address(12)]
    public int Elements { get; set; }

    public CPed this[int i]
    {
        get { return new CPed(Memory.AtOffset(0).AsPointer() + (i*0x7C4)); }
    }
}