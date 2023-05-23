using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class box : MonoBehaviour
{
    public GameObject phoneTexts;
    public static bool can_be_open;//之後改成private

    private void Start()
    {
        phoneTexts = GameObject.FindWithTag("phoneText");
        can_be_open = false;
    }
    private void OnMouseDown()
    {
        if (!can_be_open)
        {
            Debug.Log("點擊箱子(上鎖)");
            phoneTexts.GetComponent<phoneTexts>().newText("箱子被上鎖了，上面放著張紙條，要閱讀嗎?", 36, 1);
        }
        if (can_be_open)
        {
            Debug.Log("點擊箱子(解鎖)");
            phoneTexts.GetComponent<phoneTexts>().newText("裡面的紙條寫著小字:房間密碼=兩間房間的黃橘色書本數量", 36);
        }

    }

    public void unlock()
    {
        can_be_open = true;
    }
}
