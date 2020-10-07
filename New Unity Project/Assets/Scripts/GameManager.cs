using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public GameObject LevelCompleteUI;

    public void LevelComplete()
    {
        LevelCompleteUI.SetActive(true);
        FindObjectOfType<PlayerMovement>().gameIsActive = false;
    }

    public void GameOver()
    {
        FindObjectOfType<PlayerMovement>().gameIsActive = false;
        Invoke("RestartLevel", 1f);
    }

    void RestartLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
