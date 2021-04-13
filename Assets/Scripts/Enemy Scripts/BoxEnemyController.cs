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

    // Start is called before the first frame update
    void Start()
    {
        isChasing = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (isChasing)
        {
            Vector3 direction = fly.transform.position - gameObject.transform.position;
            direction.y = 0;

            timer += Time.deltaTime;
            if (timer < 10)
            {

                gameObject.transform.rotation = Quaternion.Slerp(gameObject.transform.rotation, Quaternion.LookRotation(direction), 0.1f);
                gameObject.transform.position = Vector3.MoveTowards(gameObject.transform.position, fly.transform.position, speed * Time.deltaTime);

            }
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
