using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class BoxEnemyController : MonoBehaviour
{
    public GameObject fly;
    public float speed;
    public float timer;
    private bool isChasing;

    public Transform[] waypoints;
    int currentWaypointID = 0;
    NavMeshAgent navMeshAgent;

    // Start is called before the first frame update
    void Start()
    {
        isChasing = false;
        navMeshAgent = gameObject.GetComponent<NavMeshAgent>();
        navMeshAgent.SetDestination(waypoints[currentWaypointID].position);
    }

    // Update is called once per frame
    void Update()
    {
        if (navMeshAgent.remainingDistance < 0.04f)
        {
            currentWaypointID = (currentWaypointID + 1) % waypoints.Length;
            navMeshAgent.SetDestination(waypoints[currentWaypointID].position);

        }

        if (isChasing)
        {
            gameObject.GetComponent<NavMeshAgent>().enabled = false;

            Vector3 direction = fly.transform.position - gameObject.transform.position;
            direction.y = 0;

            timer += Time.deltaTime;
            if (timer < 10)
            {

                gameObject.transform.rotation = Quaternion.Slerp(gameObject.transform.rotation, Quaternion.LookRotation(direction), 0.1f);
                gameObject.transform.position = Vector3.MoveTowards(gameObject.transform.position, fly.transform.position, speed * Time.deltaTime);

            }
        }
        else
        {
            gameObject.GetComponent<NavMeshAgent>().enabled = true;
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            isChasing = true;
            Debug.Log(isChasing);
        }
    }




















}
