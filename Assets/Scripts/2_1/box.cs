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
        if (!GameUI.GetComponent<eventController>().can_interact[0])
        {
            Debug.Log("�I���c�l(�W��)");
            hintTexts.GetComponent<hintTexts>().newText("�c�l�Q�W��F�A�W����۱i�ȱ��A�n�\Ū��?", 0);
        }
        if (GameUI.GetComponent<eventController>().can_interact[0])
        {
            Debug.Log("�I���c�l(����)");
            hintTexts.GetComponent<hintTexts>().newText("�̭����ȱ��g�ۤp�r:�ж��K�X=�ⶡ�ж��������ѥ��ƶq");
        }

    }


}
