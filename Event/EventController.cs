using System;

namespace GameHelper.Event
{
    public class EventController
    {
        public void Fire(Event e, EventArgs args)
        {
            e.InvokeListeners(args);
            e.Fire();
        }
    }
}