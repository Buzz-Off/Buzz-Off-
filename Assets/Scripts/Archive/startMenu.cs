using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class startMenu : MonoBehaviour
{
    public Button startButton;
   // public Button instructionsButton;
    public GameObject startMenuUI;
    //public bool instructions = false;

    // Start is called before the first frame update
    void Start()
    {
        startMenuUI.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        Button startBtn = startButton.GetComponent<Button>();
        startBtn.onClick.AddListener(startBtnClick);
        /*
        Button instructionsBtn = instructionsButton.GetComponent<Button>();
        instructionsBtn.onClick.AddListener(instructionsBtnClick);
        */
    }

    // If the start button gets clicked, start the game
    void startBtnClick()
    {
        startMenuUI.SetActive(false);
    }
    /*
    // If the instructions button gets clicked, switch to other panel
    void instructionsBtnClick()
    {
        
        instructions = true;
        //startMenuUI.SetActive(false);
    }
    */
}
