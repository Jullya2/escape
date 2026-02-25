using UnityEngine;

public class PlayerAttack : MonoBehaviour
{
    public GameObject attackArea;
    public float attackTime = 0.2f;

    void Start()
    {
        attackArea.SetActive(false);
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            StartCoroutine(Attack());
        }
    }

    System.Collections.IEnumerator Attack()
    {
        attackArea.SetActive(true);
        yield return new WaitForSeconds(attackTime);
        attackArea.SetActive(false);
    }
}