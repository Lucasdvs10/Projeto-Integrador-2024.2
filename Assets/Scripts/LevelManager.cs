using System.Collections;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace DefaultNamespace {
    public class LevelManager : MonoBehaviour {
        // [SerializeField] private GameObject _nextLevelBtn;
        //reutilizei o seu codigo para o level selector qqr coisa me avisa q eu crio outro script

        public Animator transition;
        public float transitionTime;

        private void Awake() {
            int nextLevelIndex = SceneManager.GetActiveScene().buildIndex + 1;
            int lastLevelIndex = SceneManager.sceneCountInBuildSettings - 1;

            if (nextLevelIndex > lastLevelIndex) {
                // _nextLevelBtn.SetActive(false);
                Debug.Log("Não há mais níveis disponíveis!", this);
            }
        }

        public void LoadNextLevel(int index)
        {
            StartCoroutine(LoadLevel(SceneManager.GetActiveScene().buildIndex + index));
            //os index das scenes precisam ser configuradas no build configs
        }
        
        public void LoadLevelByIndex(int index)
        {
            StartCoroutine(LoadLevel(index));
        }

        IEnumerator LoadLevel(int index)
        {
            transition.SetTrigger("Start");
            yield return new WaitForSeconds(transitionTime);
            SceneManager.LoadScene(index);
        }
    }
}