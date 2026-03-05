using UnityEngine;

public class Enemy : MonoBehaviour
{
    public int life = 3;

    public Transform pointA;
    public Transform pointB;

    public float speed = 2f;

    private Transform target;

    void Start()
    {
        target = pointB;
    }

    void Update()
    {
        transform.position = Vector2.MoveTowards(transform.position, target.position, speed * Time.deltaTime);

        if (Vector2.Distance(transform.position, target.position) < 0.1f)
        {
            if (target == pointA)
            {
                target = pointB;
            }
            else
            {
                target = pointA;
            }
        }
    }

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