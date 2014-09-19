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
using System.Linq;
using SAMemAPI;

namespace MemTest
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Game m = Game.Get().First();

            Console.WriteLine(m.MapTarget);
            Console.WriteLine(m.IsHUDEnabledByAnOpcode0826);

            CPed pl = m.PlayerPointer;

            PlayerPosition pos = pl.Position;

            Console.WriteLine(pos.X);

            m.CurrentHour = 6;
            m.CurrentMinute = 0;
            pos.X = 1500;
            pos.Y = -1500;
            pos.Z = 15;

            Console.ReadLine();
        }
    }
}