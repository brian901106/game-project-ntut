using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class box : MonoBehaviour
{
    public GameObject GameUI;

    private void Start()
    {
        GameUI = GameObject.FindWithTag("GameUI");
    }
    private void OnMouseDown()
    {
        if (!GameUI.GetComponent<eventController>().CheckIfProblemSolved(0))
            GameUI.GetComponent<hintTextsController>().newYN("�c�l�Q�W��F�A�W����۱i�ȱ��A�n�\Ū��?", 0);
        else
            GameUI.GetComponent<hintTextsController>().newText("�̭����ȱ��g�ۤp�r:�ж��K�X=�ⶡ�ж��������ѥ��ƶq");
    }


}
