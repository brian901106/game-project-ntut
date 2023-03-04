using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class box : MonoBehaviour
{
    public GameObject phoneTexts;

    private void Start()
    {
        phoneTexts = GameObject.FindWithTag("phoneText");
    }
    private void OnMouseDown()
    {
        Debug.Log("點擊箱子");
        
        phoneTexts.GetComponent<phoneTexts>().newText("箱子上寫著奇怪的數字2023");

    }
}
