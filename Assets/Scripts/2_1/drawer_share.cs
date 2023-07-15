using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class drawer_share : MonoBehaviour
{
    public GameObject hintTexts;
    public GameObject GameUI;
    public GameObject clue;

    private void Start()
    {
        hintTexts = GameObject.FindWithTag("hintTexts");
        GameUI = GameObject.FindWithTag("GameUI");
        clue = GameObject.FindWithTag("clue");
    }
    private void OnMouseDown()
    {
        Debug.Log("點擊共享抽屜");

        if (GameUI.GetComponent<eventController>().CheckStatus(1) == true)
        {
            hintTexts.GetComponent<hintTexts>().newText("收到隔壁房間遞來的鑰匙");
            clue.GetComponent<clue>().showClue(1);
            GameUI.GetComponent<toolBoxController>().ShowInToolbox(1);

            GameUI.GetComponent<eventController>().ChangeStatus(0, true);//箱子可以打開
            GameUI.GetComponent<eventController>().ChangeStatus(1, false);//鑰匙事件不再觸發
        }
        if (GameUI.GetComponent<eventController>().CheckStatus(1) == false)
        {
            hintTexts.GetComponent<hintTexts>().newText("抽屜空了");
        }
    }
}
