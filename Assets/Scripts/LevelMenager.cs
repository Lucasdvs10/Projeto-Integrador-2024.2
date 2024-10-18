using UnityEngine;
using UnityEngine.SceneManagement;

namespace DefaultNamespace {
    public class LevelMenager : MonoBehaviour {
        public void LoadNextLevel() {
            int nextLevelIndex = SceneManager.GetActiveScene().buildIndex + 1;
            int lastLevelIndex = SceneManager.sceneCountInBuildSettings - 1;
            
            if(nextLevelIndex > lastLevelIndex)
                Debug.Log("Não há mais níveis disponíveis!", this);
            else
                SceneManager.LoadScene(nextLevelIndex);
        }
    }
}