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
        Debug.Log("�I���F�o");

        phoneTexts.GetComponent<phoneTexts>().newText("���q�����F�o�A½�F½�ȹԤU�S���F��", 24);

    }
}
