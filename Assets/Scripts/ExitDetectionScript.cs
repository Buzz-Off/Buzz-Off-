using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ExitDetectionScript : MonoBehaviour
{
    public bool touchingExit = false;

    private void OnCollisionEnter(Collision collision)
    {
        // might have to change the name "fly" if doesn't work.
        if (collision.gameObject.name == "fly")
        {
            touchingExit = true;
            Debug.Log(touchingExit);
            // change to exit menu.
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
    }
}
