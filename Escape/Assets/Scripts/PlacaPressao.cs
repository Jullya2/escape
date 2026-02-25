using UnityEngine;

public class PlacaPressao : MonoBehaviour
{
    public Porta porta;

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
            porta.Abrir();
    }
}