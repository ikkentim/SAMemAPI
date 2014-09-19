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
using System.Reflection;
using System.Runtime.Remoting.Messaging;

namespace SAMemAPI.Proxy
{
    public class GameObjectSink : IMessageSink
    {
        private readonly MemoryObject _target;

        public GameObjectSink(IMessageSink nextSink, MemoryObject target)
        {
            NextSink = nextSink;
            _target = target;
        }

        public IMessageSink NextSink { get; private set; }

        public IMessage SyncProcessMessage(IMessage msg)
        {
            var mcm = (msg as IMethodCallMessage);

            PreProcess(ref mcm);

            return NextSink.SyncProcessMessage(msg);
        }

        public IMessageCtrl AsyncProcessMessage(IMessage msg, IMessageSink replySink)
        {
            return NextSink.AsyncProcessMessage(msg, replySink);
        }

        private void PreProcess(ref IMethodCallMessage msg)
        {
            if (msg.MethodName.StartsWith("get_"))
            {
                PropertyInfo property = _target.GetType().GetProperty(msg.MethodName.Substring(4));
                var attribute = property.GetCustomAttribute<AddressAttribute>();

                if (property.CanWrite && attribute != null)
                {
                    ProcessMemory mem = _target.Memory[attribute.Address];

                    if (property.PropertyType == typeof (int))
                        property.SetValue(_target, mem.AsInteger());
                    if (property.PropertyType == typeof (byte))
                        property.SetValue(_target, mem.AsByte());
                    if (property.PropertyType == typeof (byte[]))
                        property.SetValue(_target, mem.AsBytes(attribute.Length));
                    if (property.PropertyType == typeof (float))
                        property.SetValue(_target, mem.AsFloat());
                    if (property.PropertyType == typeof (short))
                        property.SetValue(_target, mem.AsShort());
                    if (property.PropertyType == typeof (string))
                        property.SetValue(_target, mem.AsString(attribute.Length));
                    if (property.PropertyType.IsSubclassOf(typeof (MemoryObject)))
                        property.SetValue(_target, Activator.CreateInstance(property.PropertyType, mem.AsPointer()));
                }
            }

            if (msg.MethodName.StartsWith("set_"))
            {
                PropertyInfo property = _target.GetType().GetProperty(msg.MethodName.Substring(4));
                var attribute = property.GetCustomAttribute<AddressAttribute>();

                if (property.CanWrite && attribute != null)
                {
                    ProcessMemory mem = _target.Memory[attribute.Address];

                    if (property.PropertyType == typeof (int))
                        mem.Set((int) msg.GetArg(0));
                    if (property.PropertyType == typeof (byte))
                        mem.Set((byte) msg.GetArg(0));
                    if (property.PropertyType == typeof (byte[]))
                        mem.Set((byte[]) msg.GetArg(0));
                    if (property.PropertyType == typeof (float))
                        mem.Set((float) msg.GetArg(0));
                    if (property.PropertyType == typeof (short))
                        mem.Set((short) msg.GetArg(0));
                    if (property.PropertyType == typeof (string))
                        mem.Set((string) msg.GetArg(0));
                    if (property.PropertyType.IsSubclassOf(typeof (MemoryObject)))
                    {
                        object value = msg.GetArg(0);
                        if (value != null)
                        {
                            var other = value as MemoryObject;
                            mem.Set(other.Memory.Address);
                        }
                    }
                }
            }
        }
    }
}