using System.Collections;
using Scripts.EventSystem;
using UnityEngine;
using UnityEngine.Video;

public class VideoController : MonoBehaviour {
    [SerializeField] private SOBaseGlobalEvent _onVideoPausedEvent;
    [SerializeField] private float _delayToPauseInSeconds = 5f;
    private VideoPlayer _videoPlayer;

    private void Awake() {
        _videoPlayer = GetComponent<VideoPlayer>();
        
        if(_onVideoPausedEvent is null)
            Debug.LogWarning("O evento está nulo!", this);
    }
    
    [ContextMenu("Pause Video After Delay")]
    public void PauseVideoAfterDelay() {
        StartCoroutine(PauseVideoAfterDelay(_delayToPauseInSeconds));
    }

    private IEnumerator PauseVideoAfterDelay(float delayInSeconds) {
        yield return new WaitForSeconds(delayInSeconds);
        
        _videoPlayer.Pause();
        _onVideoPausedEvent.InvokeEvent();
    }
    
    
}