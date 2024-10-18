using UnityEngine;
using UnityEngine.SceneManagement;

namespace DefaultNamespace {
    public class LevelMenager : MonoBehaviour {
        [SerializeField] private GameObject _nextLevelBtn;

        private void Awake() {
            int nextLevelIndex = SceneManager.GetActiveScene().buildIndex + 1;
            int lastLevelIndex = SceneManager.sceneCountInBuildSettings - 1;

            if (nextLevelIndex > lastLevelIndex) {
                _nextLevelBtn.SetActive(false);
                Debug.Log("Não há mais níveis disponíveis!", this);
            }
        }

        public void LoadNextLevel() {
            int nextLevelIndex = SceneManager.GetActiveScene().buildIndex + 1;
            SceneManager.LoadScene(nextLevelIndex);
        }
    }
}