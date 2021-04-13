using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IntroScript : MonoBehaviour
{
    public GameObject tutorial; 

    // Start is called before the first frame update
    void Start()
    {
        tutorial.SetActive(true);
        // pause the game
        Time.timeScale = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            tutorial.SetActive(false);
            // pause the game
            Time.timeScale = 1;
        }
    }
}
