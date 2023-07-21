using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class hintTexts : MonoBehaviour
{
    public GameObject GameUI;
    // Start is called before the first frame update
    private void Start()
    {
        GameUI = GameObject.FindWithTag("GameUI");
        GetComponent<Text>().text = "";
    }


    // Update is called once per frame
    void Update()
    {

    }
    /// <summary>
    /// 讓手機顯示新文字
    /// </summary>
    public void newText(string newText)
    {
        GameUI.GetComponent<ynButtonController>().unShowYNButtons();
        GetComponent<Text>().text = newText;
    }
    /// <summary>
    /// 讓手機顯示新文字，出現YNbutton，按下後觸發設定好的Event
    /// </summary>
    /// <param name="id">
    /// YNbutton，按下後觸發設定好的Event
    /// </param>
    public void newText(string newText, int event_id = -1)
    {
        GameUI.GetComponent<ynButtonController>().showYNButtons();
        GameUI.GetComponent<ynButtonController>().SetEventID(event_id);
        GetComponent<Text>().text = newText;
    }

    public void ChangeTextSize(int newSize)
    {
        GetComponent<Text>().fontSize = newSize;
    }

}
