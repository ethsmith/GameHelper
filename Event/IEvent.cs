using System;

namespace GameHelper.Event
{
    public abstract class Event
    {
        public abstract void Fire();

        public abstract bool IsCancellable();

        public event EventHandler<EventArgs> Handler;
        
        public void InvokeListeners(EventArgs args) => Handler?.Invoke(this, args);
    }
}