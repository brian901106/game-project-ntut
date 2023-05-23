using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class phoneTexts : MonoBehaviour
{
    private int ptext_id;
    public GameObject GameUI;
    // Start is called before the first frame update
    private void Start()
    {
        GameUI = GameObject.FindWithTag("GameUI");
        GetComponent<Text>().text = "";
        ptext_id = 0;
    }


    // Update is called once per frame
    void Update()
    {

    }

    public void newText(string newText, int newSize = 36 ,int text_id = -1)
    {
        ptext_id = text_id;
        if (ptext_id == -1)
            GameUI.GetComponent<ynButtonController>().unShowYNButtons();
        else if (ptext_id != -1)
            GameUI.GetComponent<ynButtonController>().showYNButtons();
        GetComponent<Text>().text = newText;
        GetComponent<Text>().fontSize = newSize;
    }

    public int getptextid()
    {
        return ptext_id;
    }

}
