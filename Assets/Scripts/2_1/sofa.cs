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
        Debug.Log("�I���F�o");

        phoneTexts.GetComponent<hintTexts>().newText("���q�����F�o�A½�F½�ȹԤU�S���F��");

    }
}
