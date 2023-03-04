using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sofa : MonoBehaviour
{
    public GameObject phoneTexts;

    private void Start()
    {
        phoneTexts = GameObject.FindWithTag("phoneText");
    }
    private void OnMouseDown()
    {
        Debug.Log("點擊沙發");

        phoneTexts.GetComponent<phoneTexts>().newText("普通的布沙發，翻了翻椅墊下沒有東西", 24);

    }
}
