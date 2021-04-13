using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class WinGameScript : MonoBehaviour
{
    public void PlayAgain()
    {
        Debug.Log("HELLO");
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
    }

    public void LevelSelector()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 6);
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
