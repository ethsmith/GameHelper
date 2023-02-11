namespace GameHelper.Event
{
    public abstract class CancellableEvent : Event
    {
        public abstract bool IsCancelled();
        
        public abstract void SetCancelled(bool cancelled);
    }
}