using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewEnemyController : MonoBehaviour
{
    public GameObject fly;

    public float lookDistance;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        /*if (Vector3.Distance(fly.transform.position, gameObject.transform.position) < lookDistance)
        {
            gameObject.GetComponent<Animator>().SetBool("isReady", true);

            Vector3 direction = fly.transform.position - gameObject.transform.position;
            direction.y = 0;
            gameObject.transform.rotation = Quaternion.Slerp(gameObject.transform.rotation, Quaternion.LookRotation(direction), 0.1f);

            Debug.Log("ready");
        }
        else
        {
            gameObject.GetComponent<Animator>().SetBool("isReady", false);
        }*/
    }





    













}
