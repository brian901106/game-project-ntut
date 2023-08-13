using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class box : MonoBehaviour
{
    public GameObject GameUI;

    private void Start()
    {
        GameUI = GameObject.FindWithTag("GameUI");
    }
    private void OnMouseDown()
    {
        if (!GameUI.GetComponent<eventController>().CheckIfProblemSolved(0))
            GameUI.GetComponent<hintTextsController>().newYN("箱子被上鎖了，上面放著張紙條，要閱讀嗎?", 0);
        else
            GameUI.GetComponent<hintTextsController>().newText("裡面的紙條寫著小字:房間密碼=兩間房間的黃橘色書本數量");
    }


}
