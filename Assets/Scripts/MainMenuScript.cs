using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuScript : MonoBehaviour
{
    public void PlayGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }


    // This will quit the game after when we export/build it.
    public void QuitGame()
    {
        Debug.Log("Quit");
        Application.Quit();
        // for unity editor
        UnityEditor.EditorApplication.isPlaying = false;

    }
}
