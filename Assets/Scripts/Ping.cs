using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Ping : MonoBehaviour
{
    [SerializeField] Transform target;
    [SerializeField] GameObject ping;
    NavMeshAgent agent;
    
    
    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
    }

    void Update()
    {
        float distance = Vector3.Distance(transform.position, target.position);
        if(Input.GetKeyDown(KeyCode.Mouse1))
        {
            RaycastHit hit;
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            if(Physics.Raycast(ray, out hit))
            {
                target.position = hit.point;
                ping.SetActive(true);
                agent.SetDestination(target.position);
            }
        }
        if(distance < 1.25f)
        {
            ping.SetActive(false);
        }
        else
        {
            ping.SetActive(true);
        }
    }
}
