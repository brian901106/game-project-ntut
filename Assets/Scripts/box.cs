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
        Debug.Log("�I���c�l");
        
        phoneTexts.GetComponent<phoneTexts>().newText("�c�l�W�g�۩_�Ǫ��Ʀr2023");

    }
}
