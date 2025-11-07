using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Player : MonoBehaviour
{
    public NavMeshAgent agent;

    public List<Transform> targets;

    public Transform target;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        for (int i = 0; i < 9; i++)
        {
            if (i < targets.Count && Input.GetKeyDown(""+i))
            {
                target = targets[i];
            }
        }
        agent.SetDestination(target.position);        
    }
}
