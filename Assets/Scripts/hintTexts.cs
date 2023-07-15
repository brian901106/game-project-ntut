using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class hintTexts : MonoBehaviour
{
    private int hint_id;
    public GameObject GameUI;
    // Start is called before the first frame update
    private void Start()
    {
        GameUI = GameObject.FindWithTag("GameUI");
        GetComponent<Text>().text = "";
        hint_id = 0;
    }


    // Update is called once per frame
    void Update()
    {

    }

    //newText(string 要顯示的字,
    //        int 透過id判斷是否顯示YNbutton
    //        int 字體大小(預設36),
    public void newText(string newText, int id = -1, int newSize = 36)
    {
        hint_id = id;
        if (id == -1)
            GameUI.GetComponent<ynButtonController>().unShowYNButtons();
        else if (id != -1)
            GameUI.GetComponent<ynButtonController>().showYNButtons();
        GetComponent<Text>().text = newText;
        GetComponent<Text>().fontSize = newSize;
    }

    public int getHintId()
    {
        return hint_id;
    }

}
