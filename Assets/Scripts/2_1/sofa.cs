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
        Debug.Log("�I���F�o");

        GameUI.GetComponent<hintTextsController>().newText("���q�����F�o�A½�F½�ȹԤU�S���F��");

    }
}
