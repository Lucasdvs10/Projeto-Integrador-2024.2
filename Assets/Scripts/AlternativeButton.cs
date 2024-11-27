using Scripts.EventSystem;
using UnityEngine;

namespace DefaultNamespace {
    public class AlternativeButton : MonoBehaviour {
        [SerializeField] private bool _isCorrectAnswer;
        [SerializeField] SOBaseGlobalEvent _onCorrectAnswerEvent;
        [SerializeField] SOStringGlobalEvent _onWrongAnswerEvent;
        [SerializeField] [TextArea] private string _justifyingText;

        public void CheckAnswer() {
            if (_isCorrectAnswer) {
                _onCorrectAnswerEvent.InvokeEvent();
            }
            else {
                _onWrongAnswerEvent.InvokeEvent(_justifyingText);
            }
        }
    }
}