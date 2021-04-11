using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pauseMenuScript : MonoBehaviour
{
    public GameObject pauseMenu;
    public GameObject controlsMenu;

    // Start is called before the first frame update
    void Start()
    {
        pauseMenu.SetActive(false);
        controlsMenu.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.P) || Input.GetKeyDown(KeyCode.Escape))
        {
            // pause the game
            Time.timeScale = 0;

            // activate pause menu
            pauseMenu.SetActive(true);
        }
    }

    public void resume()
    {
        // unpause the game
        pauseMenu.SetActive(false);
        controlsMenu.SetActive(false);
        Time.timeScale = 1;
    }

    public void controlMenu()
    {
        pauseMenu.SetActive(false);
        controlsMenu.SetActive(true);

        Time.timeScale = 0;
    }

    public void backButton()
    {
        pauseMenu.SetActive(true);
        controlsMenu.SetActive(false);
    }
}
