using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelSelectorScript : MonoBehaviour
{
    private void Awake()
    {
        Screen.SetResolution(1920, 1080, false);
    }

    public void Level1()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void Level2()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 3);
    }

    public void Level3()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 5);
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
