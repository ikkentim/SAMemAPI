using System.Runtime.Remoting.Activation;
using System.Runtime.Remoting.Contexts;

namespace SAMemAPI.Proxy
{
    class GameObjectAttribute : ContextAttribute
    {
        public GameObjectAttribute()
            : base("GameObject")
        {
        }

        public override void Freeze(Context newContext)
        {
        }

        public override void GetPropertiesForNewContext(IConstructionCallMessage ctorMsg)
        {
            ctorMsg.ContextProperties.Add(new GameObjectProperty());
        }

        public override bool IsContextOK(Context ctx, IConstructionCallMessage ctorMsg)
        {
            return ctx.GetProperty("GameObject") as GameObjectProperty != null;
        }

        public override bool IsNewContextOK(Context newCtx)
        {
            return newCtx.GetProperty("GameObject") as GameObjectProperty != null;
        }
    }
}
