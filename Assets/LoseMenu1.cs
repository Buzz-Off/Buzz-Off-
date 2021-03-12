using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoseMenu1 : MonoBehaviour
{
    // Lose menu is going to be at scene 3 (so we gotta -3 to go back to the start/play menu
    public void PlayAgain()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 2);
    }

    // This will quit the game after when we export/build it.
    public void QuitGame()
    {
        Debug.Log("Quit");
        Application.Quit();
    }
}