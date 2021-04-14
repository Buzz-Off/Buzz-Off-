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

    private bool isAttack;
    private bool attackInwards;
    public float closeDelay;
    public float openDelay;

    private AudioSource audioSource;

    // Start is called before the first frame update
    void Start()
    {
        LHand.GetComponent<TwoBoneIKConstraint>().weight = 0;
        RHand.GetComponent<TwoBoneIKConstraint>().weight = 0;

        audioSource = GetComponent<AudioSource>();
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

        if (LHand.GetComponent<TwoBoneIKConstraint>().weight <= 0 && RHand.GetComponent<TwoBoneIKConstraint>().weight <= 0)
        {
            Invoke("closeHandsDelay", closeDelay);
        }
        else if (LHand.GetComponent<TwoBoneIKConstraint>().weight >= 1 && RHand.GetComponent<TwoBoneIKConstraint>().weight >= 1)
        {
            Invoke("openHandsDelay", openDelay);
        }


        if (isAttack)
        {
            if (attackInwards)
            {
               //audioSource.PlayOneShot(audioSource.clip);
                attackClose();
            }
            if (!attackInwards)
            {
                attackOpen();
            }

        }
        else if (!isAttack)
        {
            attackOpen();
        }


    }

    private void openHandsDelay()
    {
        attackInwards = false;
    }
    private void closeHandsDelay()
    {
        attackInwards = true;
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
