using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class randomizedExitsScript : MonoBehaviour
{
    // random number that will be generated.
    public int randomInt;

    // exits 1-5.
    public GameObject exit_one;
    public GameObject exit_two;
    public GameObject exit_three;
    public GameObject exit_four;
    public GameObject exit_five;

    // Start is called before the first frame update.
    void Start()
    {
        // randomly generate 
        randomInt = Random.Range(1, 5);
        Debug.Log("Exit " + randomInt);
    }

    // Update is called once per frame
    void Update()
    {
        // matching the randomInt to the correct exit.
        if (randomInt == 1)
        {
            exit_one.SetActive(true);
        }
        else if (randomInt == 2)
        {
            exit_two.SetActive(true);
        }
        else if (randomInt == 3)
        {
            exit_three.SetActive(true);
        }
        else if (randomInt == 4)
        {
            exit_four.SetActive(true);
        }
        else if (randomInt == 5)
        {
            exit_five.SetActive(true);
        }
    }
}
