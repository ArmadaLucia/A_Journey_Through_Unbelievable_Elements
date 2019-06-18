using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public bool GameHasEnded = false;

    public void EndGame()
    {
        if (GameHasEnded == false)
        {
            Restart();
            Debug.Log("GameOver!");
            GameHasEnded = true;
        }

        void Restart()
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
    }
}
