using UnityEngine;
using UnityEngine.SceneManagement;

namespace DefaultNamespace {
    public class LevelMenager : MonoBehaviour {
        // [SerializeField] private GameObject _nextLevelBtn;
        //reutilizei o seu codigo para o level selector qqr coisa me avisa q eu crio outro script

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
    }
}