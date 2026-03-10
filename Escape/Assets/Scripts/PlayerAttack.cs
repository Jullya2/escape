using UnityEngine;
using System.Collections;

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
        // Botão esquerdo do mouse
        if (Input.GetMouseButtonDown(0))
        {
            StartCoroutine(Attack());
        }
    }

    IEnumerator Attack()
    {
        attackArea.SetActive(true);
        yield return new WaitForSeconds(attackTime);
        attackArea.SetActive(false);
    }
}