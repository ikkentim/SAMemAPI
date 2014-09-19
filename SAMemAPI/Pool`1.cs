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

using System;
using System.Collections;
using System.Collections.Generic;

namespace SAMemAPI
{
    public class Pool<T> : MemoryObject, IEnumerable<T> where T : MemoryObject
    {
        public Pool(ProcessMemory memory, int blockSize, int length) : base(memory)
        {
            if (blockSize <= 0) throw new ArgumentOutOfRangeException("blockSize");
            if (length <= 0) throw new ArgumentOutOfRangeException("blockSize");

            BlockSize = blockSize;
            Length = length;
        }

        public virtual int Length { get; protected set; }

        protected virtual int BlockSize { get; set; }

        public virtual T this[int i]
        {
            get
            {
                if (i < 0 || i >= Length) throw new ArgumentOutOfRangeException("i");

                return (T) Activator.CreateInstance(typeof (T), Memory[BlockSize*i]);
            }
        }

        public IEnumerator<T> GetEnumerator()
        {
            for (int i = 0; i < Length; i++)
            {
                yield return this[i];
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}