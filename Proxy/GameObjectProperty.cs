using System;
using System.Runtime.Remoting.Contexts;
using System.Runtime.Remoting.Messaging;

namespace SAMemAPI.Proxy
{
    public class GameObjectProperty : IContextProperty, IContributeObjectSink
    {
        public string Name
        {
            get { return "GameObject"; }
        }

        public bool IsNewContextOK(Context newCtx)
        {
            return newCtx.GetProperty("GameObject") as GameObjectProperty != null;
        }
        
        public void Freeze(Context newContext)
        {
        }

        public IMessageSink GetObjectSink(MarshalByRefObject obj, IMessageSink nextSink)
        {
            return new GameObjectSink(nextSink, obj as MemoryObject);
        }
    }
}
