using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoseMenu2 : MonoBehaviour
{
    // Lose menu is going to be at scene 3 (so we gotta -3 to go back to the start/play menu
    public void PlayAgain()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
    }

    public void LevelSelector()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 4);
    }


    // This will quit the game after when we export/build it.
    public void QuitGame()
    {
        Debug.Log("Quit");
        Application.Quit();
        // for unity editor
        //UnityEditor.EditorApplication.isPlaying = false;
    }
}