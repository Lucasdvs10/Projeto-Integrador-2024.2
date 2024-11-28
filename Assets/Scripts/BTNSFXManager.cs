using System;
using System.Collections;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace DefaultNamespace {
    [RequireComponent(typeof(AudioSource))]
    public class BTNSFXManager : MonoBehaviour {
        private Button _button;
        private AudioSource _audioSource;
        [SerializeField] private AudioClip _sfx;
        public UnityEvent _onSFXEnded;

        private void Awake() {
            _button = GetComponent<Button>();
            _audioSource = GetComponent<AudioSource>();
            
            if(_button is null)
                Debug.LogError("Button component not found!", this);
            
            if(_onSFXEnded is null)
                Debug.LogError("UnityEvent _onSFXEnded not found!", this);
            
        }

        private void OnEnable() {
            _button.onClick.AddListener(PlaySFXOnClick);
        }

        private void OnDisable() {
            _button.onClick.RemoveListener(PlaySFXOnClick);
        }

        public void PlaySFXOnClick() {
            if(_audioSource.isPlaying) return;
            StartCoroutine(PlaySFX());
        }

        private IEnumerator PlaySFX() {
            _audioSource.clip = _sfx;
            _audioSource.Play();
            yield return new WaitForSeconds(0.19f);
            _onSFXEnded.Invoke();
        }
        
    }
}