using UnityEngine;

public class Lever : MonoBehaviour
{
    public GameObject door;

    private bool playerNear = false;
    private bool activated = false;
    private PlayerKeys playerKeys;

    void Update()
    {
        if (playerNear && Input.GetKeyDown(KeyCode.E) && !activated)
        {
            if (playerKeys != null && playerKeys.UseKey())
            {
                activated = true;
                door.SetActive(false);
                Debug.Log("Alavanca ativada! Porta aberta.");
            }
            else
            {
                Debug.Log("Você precisa de uma chave!");
            }
        }
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            playerNear = true;
            playerKeys = other.GetComponent<PlayerKeys>();
        }
    }

    void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            playerNear = false;
            playerKeys = null;
        }
    }
}