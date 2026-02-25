using UnityEngine;

public class Alavanca : MonoBehaviour
{
    public Porta porta;
    bool ativada;

    void OnTriggerStay2D(Collider2D other)
    {
        if (other.CompareTag("Player") && Input.GetKeyDown(KeyCode.E))
        {
            if (ativada) return;
            ativada = true;
            porta.Abrir();
        }
    }
}