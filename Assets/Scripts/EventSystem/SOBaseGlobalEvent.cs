using System;
using UnityEngine;

namespace Scripts.EventSystem {
    
    [CreateAssetMenu(fileName = "GameEvent", menuName = "GameEvent")]
    public class SOBaseGlobalEvent : ScriptableObject{
        
        private event Action OnEventRaised;

        protected virtual void OnEnable() {
            OnEventRaised = null;
        }

        public void InvokeEvent() {
            OnEventRaised?.Invoke();
        }
        
        public void Subscribe(Action action) {
            OnEventRaised += action;
        }

        public void Unsubscribe(Action action) {
            OnEventRaised -= action;
        }
    }
}