using UnityEngine;
using UnityEngine.SceneManagement;

public class MusicManager : MonoBehaviour
{
    public static MusicManager instance;

    public AudioSource audioSource;
    public AudioClip menuCreditsMusic;
    public AudioClip gameMusic;

    void Awake()
    {
        if (instance != null)
        {
            Destroy(gameObject);
            return;
        }

        instance = this;
        DontDestroyOnLoad(gameObject);

        SceneManager.sceneLoaded += OnSceneLoaded;
    }

    void OnSceneLoaded(Scene scene, LoadSceneMode mode)
    {
        // Menu e Créditos
        if (scene.name == "Menu" || scene.name == "Creditos")
        {
            PlayMusic(menuCreditsMusic);
        }
        // Jogo
        else if (scene.name == "CenaJogo")
        {
            PlayMusic(gameMusic);
        }
    }

    void PlayMusic(AudioClip music)
    {
        if (audioSource.clip == music) return;

        audioSource.clip = music;
        audioSource.loop = true;
        audioSource.Play();
    }
}