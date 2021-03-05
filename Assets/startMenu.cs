using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class startMenu : MonoBehaviour
{
    public Button startButton;
    public GameObject startMenuUI;
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

        if (Input.GetKeyDown(KeyCode.Space))
        {
            startMenuUI.SetActive(false);
        }

    }

    void startBtnClick()
    {
        startMenuUI.SetActive(false);
    }

}
