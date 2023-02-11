using System;

namespace GameHelper.Event
{
    public interface IEventListener
    {
        public Event GetEvent();
        
        public void OnFire(object sender, EventArgs args);
    }
}