using UnityEngine;
using UnityEngine.Events;

namespace Scripts.EventSystem {
    public class EventListener : MonoBehaviour{

        [SerializeField] private SOBaseGlobalEvent _eventToListen;
        public UnityEvent UnityEventEmiter;

        private void OnEnable() {
            _eventToListen.Subscribe(UnityEventEmiter.Invoke);
        }

        private void OnDisable() {
            _eventToListen.Unsubscribe(UnityEventEmiter.Invoke);
        }
    }
}