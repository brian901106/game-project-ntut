using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class box : MonoBehaviour
{
    public GameObject hintTexts;
    public GameObject GameUI;

    private void Start()
    {
        hintTexts = GameObject.FindWithTag("hintTexts");
        GameUI = GameObject.FindWithTag("GameUI");
    }
    private void OnMouseDown()
    {
        if (!GameUI.GetComponent<eventController>().can_interact[0])
        {
            Debug.Log("點擊箱子(上鎖)");
            hintTexts.GetComponent<hintTexts>().newText("箱子被上鎖了，上面放著張紙條，要閱讀嗎?", 0);
        }
        if (GameUI.GetComponent<eventController>().can_interact[0])
        {
            Debug.Log("點擊箱子(解鎖)");
            hintTexts.GetComponent<hintTexts>().newText("裡面的紙條寫著小字:房間密碼=兩間房間的黃橘色書本數量");
        }

    }


}
