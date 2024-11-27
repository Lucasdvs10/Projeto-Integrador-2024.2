using System.Collections;
using Scripts.EventSystem;
using UnityEngine;
using UnityEngine.Video;

public class VideoController : MonoBehaviour {
    [SerializeField] private SOBaseGlobalEvent _onVideoPausedEvent;
    [SerializeField] private float _delayToPauseInSeconds = 5f;
    [SerializeField] private GameObject _endScreenGameobj;
    private VideoPlayer _videoPlayer;

    private void Awake() {
        _videoPlayer = GetComponent<VideoPlayer>();
        PauseVideoAfterDelay();
        
        if(_onVideoPausedEvent is null)
            Debug.LogWarning("O evento está nulo!", this);
    }
    
    [ContextMenu("Pause Video After Delay")]
    public void PauseVideoAfterDelay() {
        StartCoroutine(PauseVideoAfterDelay(_delayToPauseInSeconds));
    }
    
    [ContextMenu("Resume Video")]
    public void ResumeVideo() {
        StartCoroutine(ResumeVideoCO());
    }

    private IEnumerator ResumeVideoCO() {
        _videoPlayer.Play();
        yield return new WaitUntil(() => !_videoPlayer.isPlaying);
        Canvas canvas = FindObjectOfType<Canvas>();
        Instantiate(_endScreenGameobj, canvas.transform);
    }

    private IEnumerator PauseVideoAfterDelay(float delayInSeconds) {
        yield return new WaitForSeconds(delayInSeconds);
        
        _videoPlayer.Pause();
        _onVideoPausedEvent.InvokeEvent();
    }
    
    
}