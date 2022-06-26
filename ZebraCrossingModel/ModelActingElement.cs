using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZebraCrossingModel
{
    public abstract class ModelActingElement : ModelElement
    {
        protected Action elemAction;
        protected abstract void CheckEvents();
        protected ModelActingElement(Action<string> notification) : base(notification)
        {
            elemAction = null;
        }
        public override void Start()
        {
            while (!IsStopped)
            {
                CheckEvents();
                elemAction?.Invoke();
                Task.Delay(30).Wait();
            }
        }
    }
}
