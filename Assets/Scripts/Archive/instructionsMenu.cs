using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class instructionsMenu : MonoBehaviour
{
    public startMenu start;
    public GameObject instructionsMenuUI;
    public Button ins;



    // Start is called before the first frame update
    void Start()
    {
        //instructionsMenuUI.SetActive(false);
        instructionsMenuUI.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        /*
        if (start.instructions)
        {
            Debug.Log("HELLO");
            instructionsMenuUI.SetActive(true);
        }
        */
        Debug.Log("HERHE");
        Button instructionsBtn = ins.GetComponent<Button>();
        instructionsBtn.onClick.AddListener(instructionsBtnClick);

    }

    void instructionsBtnClick()
    {

        instructionsMenuUI.SetActive(true);

    }

    public void toggleVisibility()
    {
        Renderer rend = gameObject.GetComponent<Renderer>();

        rend.enabled = false;

        if (rend.enabled)
        {
            rend.enabled = false;
        }
        else
        {
            rend.enabled = true;
        }
    }
}
