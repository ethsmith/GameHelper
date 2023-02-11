using System.Collections.Generic;
using UnityEngine;

namespace GameHelper.State
{
    public class StateController
    {
        private readonly List<IState> _states = new();
        
        public IState CurrentState { get; private set; }
        
        public void AddState(IState state)
        {
            _states.Add(state);
        }
        
        public void RemoveState(IState state)
        {
            _states.Remove(state);
        }
        
        public void SetState(IState state)
        {
            if (CurrentState != null && CurrentState.IsReadyForExit())
            {
                CurrentState.Exit();
                UnregisterListeners();
            }
            
            CurrentState = state;
            CurrentState.Enter();
            RegisterListeners();
            
            Debug.Log($"Current state: {CurrentState.GetType().Name}");
        }

        public IState GetState(string id) => _states.Find(state => state.Id == id);

        private void RegisterListeners()
        {
            foreach (var eventListener in CurrentState.GetListeners())
            {
                eventListener.GetEvent().Handler += eventListener.OnFire;
            }
        }
        
        private void UnregisterListeners()
        {
            foreach (var eventListener in CurrentState.GetListeners())
            {
                eventListener.GetEvent().Handler -= eventListener.OnFire;
            }
        }
    }
}