using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    
    public string sceneGame = "Dungeon";
    public string sceneCredits = "Credits";

    public void StartGame()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene(sceneGame);
    }

    public void GoToCredits()
    {
        SceneManager.LoadScene(sceneCredits);
    }

    public void QuitGame()
    {
        Debug.Log("Saindo do jogo...");
        Application.Quit();
    }
}