using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.SceneManagement;

public class WalkingModeScript : MonoBehaviour
{
    private Animator anim;

    public Transform[] waypoints;

    int currentWaypointID = 0;

    enum EnemyState { Patrol, Pursue };

    EnemyState currentState = EnemyState.Patrol;
    NavMeshAgent navMeshAgent;

    public bool touchingExit = false;

    public GameObject enemy;

    void Start()
    {
        //GetComponent<NavMeshAgent>().SetDestination(waypoints[currentWaypointID].position);
        navMeshAgent = GetComponent<NavMeshAgent>();
        navMeshAgent.SetDestination(waypoints[currentWaypointID].position);
        //enemy.GetComponent<Animator>().SetBool("isWalking", false);
        Debug.Log("WALKING IS: " + enemy.GetComponent<Animator>().GetBool("isWalking"));
        Debug.Log("rEADY IS: " + enemy.GetComponent<Animator>().GetBool("isReady"));
    }


    void Update()
    {

        if (enemy.GetComponent<Animator>().GetBool("isWalking"))
        {
            Debug.Log("IT IS: " + enemy.GetComponent<Animator>().GetBool("isWalking"));
            enemy.GetComponent<Animator>().SetBool("isReady", false);

            if (navMeshAgent.remainingDistance < 0.04f)
            {
                currentWaypointID = (currentWaypointID + 1) % waypoints.Length;
                navMeshAgent.SetDestination(waypoints[currentWaypointID].position);

            }
        }
    }
}
