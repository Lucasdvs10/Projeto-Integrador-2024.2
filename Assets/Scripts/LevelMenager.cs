using UnityEngine;
using UnityEngine.SceneManagement;

namespace DefaultNamespace {
    public class LevelMenager : MonoBehaviour {
        private void Awake() {
            int nextLevelIndex = SceneManager.GetActiveScene().buildIndex + 1;
            int lastLevelIndex = SceneManager.sceneCountInBuildSettings - 1;

            if (nextLevelIndex > lastLevelIndex) {
                // _nextLevelBtn.SetActive(false);
                Debug.Log("Não há mais níveis disponíveis!", this);
            }
        }

        public void LoadNextLevel(int index) {
            int nextLevelIndex = SceneManager.GetActiveScene().buildIndex + index;
            SceneManager.LoadScene(nextLevelIndex);
            //os index das scenes precisam ser configuradas no build configs
        }
        
        public void LoadNextLevel(string index) {
            SceneManager.LoadScene(index);
        }
    }
}