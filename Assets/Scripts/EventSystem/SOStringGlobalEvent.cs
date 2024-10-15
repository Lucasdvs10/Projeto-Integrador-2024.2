using System;
using UnityEngine;

namespace Scripts.EventSystem {
    [CreateAssetMenu(fileName = "String event", menuName = "GameEvent/String event", order = 0)]
    public class SOStringGlobalEvent : ScriptableObject {
        private event Action<string> OnEventRaised;

        protected virtual void OnEnable() {
            OnEventRaised = null;
        }

        public void InvokeEvent(string value) {
            OnEventRaised?.Invoke(value);
        }
        
        public void Subscribe(Action<string> action) {
            OnEventRaised += action;
        }

        public void Unsubscribe(Action<string> action) {
            OnEventRaised -= action;
        }
    }
}