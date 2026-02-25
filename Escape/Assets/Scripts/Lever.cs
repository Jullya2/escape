using UnityEngine;

public class Lever : MonoBehaviour
{
    public GameObject door;
    private bool playerNear;
    private bool activated;

    void Update()
    {
        if (playerNear && Input.GetKeyDown(KeyCode.E) && !activated)
        {
            activated = true;
            door.SetActive(false);
        }
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            playerNear = true;
        }
    }

    void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            playerNear = false;
        }
    }
}