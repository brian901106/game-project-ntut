using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sofa : MonoBehaviour
{
    public GameObject GameUI;

    private void Start()
    {
        GameUI = GameObject.FindWithTag("GameUI");
    }
    private void OnMouseDown()
    {
        Debug.Log("點擊沙發");

        GameUI.GetComponent<hintTextsController>().newText("普通的布沙發，翻了翻椅墊下沒有東西");

    }
}
