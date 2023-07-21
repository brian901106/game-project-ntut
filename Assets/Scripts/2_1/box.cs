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
        if (!GameUI.GetComponent<eventController>().CheckIfProblemSolved(0))
            hintTexts.GetComponent<hintTexts>().newText("�c�l�Q�W��F�A�W����۱i�ȱ��A�n�\Ū��?", 0);
        else
            hintTexts.GetComponent<hintTexts>().newText("�̭����ȱ��g�ۤp�r:�ж��K�X=�ⶡ�ж��������ѥ��ƶq");
        Debug.Log("1");
    }


}
