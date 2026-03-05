using UnityEngine;

public class Enemy : MonoBehaviour
{
    public int life = 3;
    public int damage = 1;

    public Transform pointA;
    public Transform pointB;
    public float speed = 2f;

    public VictoryManager victoryManager;

    private Transform target;

    void Start()
    {
        target = pointB;
    }

    void Update()
    {
        transform.position = Vector2.MoveTowards(transform.position, target.position, speed * Time.deltaTime);

        if (Vector2.Distance(transform.position, target.position) <= 0.05f)
        {
            if (target == pointB)
                target = pointA;
            else
                target = pointB;
        }
    }

    void OnTriggerEnter2D(Collider2D other)
    {
       
        if (other.CompareTag("Player"))
        {
            PlayerLife player = other.GetComponent<PlayerLife>();

            if (player != null)
            {
                player.TakeDamage(damage);
            }
        }

     
        if (other.CompareTag("Attack"))
        {
            life--;

            if (life <= 0)
            {
                victoryManager.ShowVictory();
                Destroy(gameObject);
            }
        }
    }
}