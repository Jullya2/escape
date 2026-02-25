using UnityEngine;

public class Enemy : MonoBehaviour
{
    public int life = 3;

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Attack"))
        {
            life--;
            if (life <= 0)
            {
                Destroy(gameObject);
            }
        }
    }
}