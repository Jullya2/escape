using UnityEngine;

public class Key : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            PlayerKeys playerKeys = other.GetComponent<PlayerKeys>();

            if (playerKeys != null)
            {
                playerKeys.AddKey();
                Destroy(gameObject);
            }
        }
    }
}