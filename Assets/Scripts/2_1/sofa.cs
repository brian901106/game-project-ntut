using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sofa : MonoBehaviour
{
    public GameObject phoneTexts;

    private void Start()
    {
        phoneTexts = GameObject.FindWithTag("hintTexts");
    }
    private void OnMouseDown()
    {
        Debug.Log("點擊沙發");

        phoneTexts.GetComponent<hintTexts>().newText("普通的布沙發，翻了翻椅墊下沒有東西");

    }
}
