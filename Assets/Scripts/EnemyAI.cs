using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.SceneManagement;

public class EnemyAI : MonoBehaviour
{
    // Start is called before the first frame update

    public Transform[] waypoints;

    int currentWaypointID = 0;

    enum EnemyState { Patrol, Pursue };

    EnemyState currentState = EnemyState.Patrol;
    NavMeshAgent navMeshAgent;

    public bool touchingExit = false;

    void Start()
    {
        //GetComponent<NavMeshAgent>().SetDestination(waypoints[currentWaypointID].position);
        navMeshAgent = GetComponent<NavMeshAgent>();
        navMeshAgent.SetDestination(waypoints[currentWaypointID].position);
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


    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name == "Player")
        {
            touchingExit = true;
            Debug.Log(touchingExit);
            // change to exit menu.
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 2);
        }
    }

}