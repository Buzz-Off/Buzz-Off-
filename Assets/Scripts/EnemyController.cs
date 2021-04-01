using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Animations.Rigging;

public class EnemyController : MonoBehaviour
{
    public GameObject fly;
    public GameObject LArm;
    public GameObject RArm;
    public GameObject LTarget;
    public GameObject RTarget;

    public float lookDistance;
    //public float attackDistance;


    // Start is called before the first frame update
    void Start()
    {
        attackOpen();
    }

    // Update is called once per frame
    void Update()
    {

        if (Vector3.Distance(fly.transform.position, gameObject.transform.position) < lookDistance)
        {
            Vector3 direction = fly.transform.position - gameObject.transform.position;
            direction.y = 0;
            gameObject.transform.rotation = Quaternion.Slerp(gameObject.transform.rotation, Quaternion.LookRotation(direction), 0.1f);

            
        }
        
    }

    private void attackOpen()
    {
        LArm.GetComponent<TwoBoneIKConstraint>().weight = 0;
        RArm.GetComponent<TwoBoneIKConstraint>().weight = 0;
    }
    private void attackClose()
    {
        LArm.GetComponent<TwoBoneIKConstraint>().weight = 1;
        RArm.GetComponent<TwoBoneIKConstraint>().weight = 1;

    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            Debug.Log("enter");


            LTarget.transform.position = fly.transform.position;
            RTarget.transform.position = fly.transform.position;
            attackClose();
        }
        
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {

            Debug.Log("exit"); 
            attackOpen();
        }
    }


}
