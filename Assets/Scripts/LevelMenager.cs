using UnityEngine;
using UnityEngine.SceneManagement;

namespace DefaultNamespace {
    public class LevelMenager : MonoBehaviour {
        public void LoadNextLevel() {
            int nextLevelIndex = SceneManager.GetActiveScene().buildIndex + 1;
            SceneManager.LoadScene(nextLevelIndex);
        }
    }
}