using UnityEngine;
using UnityEngine.Events;

namespace Scripts.EventSystem {
    public class StringEventListener : MonoBehaviour{

        [SerializeField] private SOStringGlobalEvent _eventToListen;
        public UnityEvent<string> UnityEventEmiter;

        private void OnEnable() {
            _eventToListen.Subscribe(UnityEventEmiter.Invoke);
        }

        private void OnDisable() {
            _eventToListen.Unsubscribe(UnityEventEmiter.Invoke);
        }
    }
}