using UnityEngine;
using UnityEngine.UI;

namespace Scripts.EventSystem {

    enum RotateDirection {
        RIGHT = 0,
        UP = 90,
        LEFT = 180,
        DOWN = 270
    }
    
    public class RotateSelectorIndicator : MonoBehaviour {
        [SerializeField] private Sprite _selectedSprite;
        [SerializeField] RotateDirection _rotateDirection;
        private Image _indicatorSpriteRenderer;
        private Sprite _defaultSprite;
        
        private void Awake() {
            _indicatorSpriteRenderer = GameObject.FindGameObjectWithTag("Indicator").GetComponent<Image>();
            _defaultSprite = _indicatorSpriteRenderer.sprite;
        }

        public void RotateIndicator() {
            _indicatorSpriteRenderer.sprite = _selectedSprite;
            _indicatorSpriteRenderer.SetNativeSize();
            _indicatorSpriteRenderer.transform.rotation = Quaternion.Euler(0, 0, (float)_rotateDirection);
        }
        
        public void ResetIndicator() {
            _indicatorSpriteRenderer.sprite = _defaultSprite;
            _indicatorSpriteRenderer.SetNativeSize();
        }
    }
}