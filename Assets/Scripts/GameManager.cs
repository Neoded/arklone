using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    int blocksLeft;
    int activeSceneIndex;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        blocksLeft = GameObject.FindGameObjectsWithTag("Block").Length;
    }
    public void DecreaseBlocks()
    {
        blocksLeft--;
        if (blocksLeft <= 0)
        {
            LoadNextScene();
        }
    }

    public void LoadNextScene()
    {
        activeSceneIndex = SceneManager.GetActiveScene().buildIndex;
        SceneManager.LoadScene(activeSceneIndex + 1);
    }

    public void RestartScene()
    {
        activeSceneIndex = SceneManager.GetActiveScene().buildIndex;
        SceneManager.LoadScene(activeSceneIndex);
    }

    public void QuitGame()
    {
        Application.Quit();
    }
}
