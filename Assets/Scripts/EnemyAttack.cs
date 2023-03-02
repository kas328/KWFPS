using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAttack : MonoBehaviour
{
    Transform target;
    [SerializeField] Animator animator;
    PlayerHP playerHP;

    private void Awake()
    {
        target = GameObject.Find("Player").transform;
        playerHP = target.GetComponent<PlayerHP>();
    }

    private void Update()
    {
        Vector3 targetPos = target.position;
        targetPos.y = transform.position.y;
        transform.LookAt(targetPos);

        animator.SetBool("IsAttack", Vector3.Distance(target.position, transform.position) < 3);
    }

    public void OnAttack()
    {
        playerHP.CurrentHP--;
    }
}
