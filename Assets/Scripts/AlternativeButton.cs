using System;
using Scripts.EventSystem;
using UnityEngine;
using UnityEngine.UI;

namespace DefaultNamespace {
    public class AlternativeButton : MonoBehaviour {
        [SerializeField] private bool _isCorrectAnswer;
        [SerializeField] SOBaseGlobalEvent _onCorrectAnswerEvent;
        [SerializeField] SOStringGlobalEvent _onWrongAnswerEvent;
        [SerializeField] [TextArea] private string _justifyingText;
        private Button _button;

        private void Start() {
            _button = GetComponent<Button>();
            _button.onClick.AddListener(CheckAnswer);
        }

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