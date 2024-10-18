using TMPro;
using UnityEngine;

namespace DefaultNamespace {
    public class WrongAlternativeScreen : MonoBehaviour {
        private TextMeshProUGUI _textMeshPro;

        private void Awake() {
            _textMeshPro = GetComponentInChildren<TextMeshProUGUI>();
        }

        public void SetText(string text) {
            _textMeshPro.text = text;
        }
    }
}