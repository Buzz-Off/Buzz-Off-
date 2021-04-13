using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.SceneManagement;

public class walkingMode : MonoBehaviour
{
    //private Animator anim;
    public Transform[] waypoints;
    int currentWaypointID = 0;
    NavMeshAgent navMeshAgent;
    public bool touchingExit = false;

    /*enum EnemyState { Patrol, Pursue };
    EnemyState currentState = EnemyState.Patrol;
    public GameObject enemy;*/


    void Start()
    {
        //GetComponent<NavMeshAgent>().SetDestination(waypoints[currentWaypointID].position);
        navMeshAgent = gameObject.GetComponent<NavMeshAgent>();
        navMeshAgent.SetDestination(waypoints[currentWaypointID].position);
        //enemy.GetComponent<Animator>().SetBool("isWalking", false);
        /*Debug.Log("WALKING IS: " + enemy.GetComponent<Animator>().GetBool("isWalking"));
        Debug.Log("rEADY IS: " + enemy.GetComponent<Animator>().GetBool("isReady"));*/
    }


    void Update()
    {
        if (navMeshAgent.remainingDistance < 0.04f)
        {
            currentWaypointID = (currentWaypointID + 1) % waypoints.Length;
            navMeshAgent.SetDestination(waypoints[currentWaypointID].position);

        }

        if (gameObject.GetComponent<Animator>().GetBool("isReady"))
        {
            Debug.Log("IT IS: " + gameObject.GetComponent<Animator>().GetBool("isWalking"));
            gameObject.GetComponent<NavMeshAgent>().enabled = false;

        }
        else
        {
            gameObject.GetComponent<NavMeshAgent>().enabled = true;
        }
    }
}
