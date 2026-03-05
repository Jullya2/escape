using UnityEngine;

public class PlayerLife : MonoBehaviour
{
    public int life = 5;

    public void TakeDamage(int damage)
    {
        life -= damage;

        Debug.Log("Player levou dano! Vida atual: " + life);

        if (life <= 0)
        {
            Debug.Log("Player morreu!");
            Destroy(gameObject);
        }
    }
}