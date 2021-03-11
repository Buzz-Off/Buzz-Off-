using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Enemy_AI : MonoBehaviour
{

    public Transform[] waypoints;
   
    int currentWaypointID = 0;

    enum EnemyState {Patrol, Pursue};

    EnemyState currentState = EnemyState.Patrol;
    NavMeshAgent navMeshAgent;
    // Start is called before the first frame update
    void Start()
    {
        navMeshAgent = GetComponent<NavMeshAgent>();
        GetComponent<NavMeshAgent>().SetDestination(waypoints[currentWaypointID].position);
    }

    // Update is called once per frame
    void Update()
    {
        switch (currentState)
        {
            case EnemyState.Patrol:
                if (navMeshAgent.remainingDistance < 0.04f)
                {
                    currentWaypointID = (currentWaypointID + 1) % waypoints.Length;
                    navMeshAgent.SetDestination(waypoints[currentWaypointID].position);
                }
                break;
            case EnemyState.Pursue:
                break;
            default:
                break;
        }
    }
}
