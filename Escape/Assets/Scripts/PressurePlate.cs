using UnityEngine;

public class PressurePlate : MonoBehaviour
{
    public bool activated = false;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Box"))
        {
            activated = true;
        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("Box"))
        {
            activated = false;
        }
    }
}