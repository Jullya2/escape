using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject victoryScreen;
    public GameObject defeatScreen;

    public void ShowVictory()
    {
        victoryScreen.SetActive(true);
        Time.timeScale = 0f;
    }

    public void ShowDefeat()
    {
        defeatScreen.SetActive(true);
        Time.timeScale = 0f;
    }
}