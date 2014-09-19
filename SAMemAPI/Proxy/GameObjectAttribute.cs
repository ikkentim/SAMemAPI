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

using System.Runtime.Remoting.Activation;
using System.Runtime.Remoting.Contexts;

namespace SAMemAPI.Proxy
{
    internal class GameObjectAttribute : ContextAttribute
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