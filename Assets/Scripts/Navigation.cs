using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Navigation : MonoBehaviour
{
    NavMeshAgent agent;
    GameObject target;
    EnemyHP enemyHP;

    void Awake()
    {
        agent = GetComponent<NavMeshAgent>();
        target = GameObject.Find("Player");
        enemyHP = GetComponent<EnemyHP>();
    }

    void Update()
    {
        if (enemyHP.IsDie) agent.ResetPath();
        else agent.SetDestination(target.transform.position);
    }
}
