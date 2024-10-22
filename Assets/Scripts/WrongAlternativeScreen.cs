using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

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