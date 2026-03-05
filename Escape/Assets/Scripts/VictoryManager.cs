using UnityEngine;

public class VictoryManager : MonoBehaviour
{
    public GameObject victoryScreen;

    public void ShowVictory()
    {
        victoryScreen.SetActive(true);
        Time.timeScale = 0f;
    }
}