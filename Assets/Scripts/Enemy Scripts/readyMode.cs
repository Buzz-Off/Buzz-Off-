using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class readyMode : MonoBehaviour
{
    public GameObject enemy;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
   
        
    }


    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            enemy.GetComponent<Animator>().SetBool("isReady", true);

            Vector3 direction = other.gameObject.transform.position - enemy.transform.position;
            direction.y = 0;
            enemy.transform.rotation = Quaternion.Slerp(enemy.transform.rotation, Quaternion.LookRotation(direction), 0.1f);

            //Debug.Log("ready");
        }
    }

    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            Vector3 direction = other.gameObject.transform.position - enemy.transform.position;
            direction.y = 0;
            enemy.transform.rotation = Quaternion.Slerp(enemy.transform.rotation, Quaternion.LookRotation(direction), 0.1f);

            //Debug.Log("rotate");
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            enemy.GetComponent<Animator>().SetBool("isReady", false);
        }
            
    }
}

