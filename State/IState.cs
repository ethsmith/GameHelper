using GameHelper.Event;
using UnityEngine;

namespace GameHelper.State
{
    public interface IState
    {
        string Id { get; set; }

        int Priority { get; set; }
        
        void Enter();
        
        void Exit();
        
        bool IsReadyForExit();
        
        void SetListeners(params IEventListener[] listeners);
        
        IEventListener[] GetListeners();
    }
}
