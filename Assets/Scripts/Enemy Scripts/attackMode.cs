using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Animations.Rigging;

public class attackMode : MonoBehaviour
{
    public GameObject fly;
    public GameObject LHand;
    public GameObject RHand;
    public GameObject LTarget;
    public GameObject RTarget;
    public float attackSpeed;
    public float timer;

    public float test;

    private bool isAttack;
    private bool isAttackClosed = false;



    // Start is called before the first frame update
    void Start()
    {
        LHand.GetComponent<TwoBoneIKConstraint>().weight = 0;
        RHand.GetComponent<TwoBoneIKConstraint>().weight = 0;
    }

    // Update is called once per frame
    void Update()
    {
        /*if (isAttack)
        {
            LHand.GetComponent<TwoBoneIKConstraint>().weight += attackSpeed * Time.deltaTime;
            RHand.GetComponent<TwoBoneIKConstraint>().weight += attackSpeed * Time.deltaTime;

            if (LHand.GetComponent<TwoBoneIKConstraint>().weight >= 1 && RHand.GetComponent<TwoBoneIKConstraint>().weight >= 1)
            {
                timer += Time.deltaTime;
                if (timer > 10)
                {
                    if (LHand.GetComponent<TwoBoneIKConstraint>().weight > 0 && RHand.GetComponent<TwoBoneIKConstraint>().weight > 0)
                    {
                        LHand.GetComponent<TwoBoneIKConstraint>().weight -= attackSpeed * Time.deltaTime;
                        RHand.GetComponent<TwoBoneIKConstraint>().weight -= attackSpeed * Time.deltaTime;
                        
                    }
                    
                }
            }

            timer = 0;
        }*/
        
        if (isAttack)
        {
            //isAttackClosed = false;
            while (LHand.GetComponent<TwoBoneIKConstraint>().weight < 1 && RHand.GetComponent<TwoBoneIKConstraint>().weight < 1)
            {
                attackClose();
            }
            //isAttackClosed = true;
            while (LHand.GetComponent<TwoBoneIKConstraint>().weight > 0 && RHand.GetComponent<TwoBoneIKConstraint>().weight > 0)
            {
                attackOpen();
            }
            

            

            /*if (LHand.GetComponent<TwoBoneIKConstraint>().weight >= 1 && RHand.GetComponent<TwoBoneIKConstraint>().weight >= 1)
            {
                isAttack2 = true;
                Debug.Log(isAttack2);
            }*/


        }
        else if (!isAttack)
        {
            attackOpen();
        }

        /*if (isAttack2)
        {
            Debug.Log("help");
            timer += Time.deltaTime;
            if (timer > 5)
            {
                LHand.GetComponent<TwoBoneIKConstraint>().weight -= attackSpeed * Time.deltaTime;
                RHand.GetComponent<TwoBoneIKConstraint>().weight -= attackSpeed * Time.deltaTime;

            }
            timer = 0;
        }*/
    }

    private void attackOpen()
    {
        
        LHand.GetComponent<TwoBoneIKConstraint>().weight -= attackSpeed * Time.deltaTime;
        RHand.GetComponent<TwoBoneIKConstraint>().weight -= attackSpeed * Time.deltaTime;
    }
    private void attackClose()
    {
        LHand.GetComponent<TwoBoneIKConstraint>().weight += attackSpeed * Time.deltaTime;
        RHand.GetComponent<TwoBoneIKConstraint>().weight += attackSpeed * Time.deltaTime;

    }

    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            //Debug.Log("enter");


            LTarget.transform.position = fly.transform.position;
            RTarget.transform.position = fly.transform.position;
            isAttack = true;
            
        }

    }
    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {

            Debug.Log("exit");
            isAttack = false;
        }
    }
}
