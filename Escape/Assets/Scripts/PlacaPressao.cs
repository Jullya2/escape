using UnityEngine;

public class PlacaPressao : MonoBehaviour
{
    public GameObject porta;

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.layer == LayerMask.NameToLayer("Box"))
        {
            porta.SetActive(false);
        }
    }

    void OnTriggerExit2D(Collider2D other)
    {
        if (other.gameObject.layer == LayerMask.NameToLayer("Box"))
        {
            porta.SetActive(true);
        }
    }
}