using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class drawer_share : MonoBehaviour
{
    public GameObject hintTexts;
    public GameObject GameUI;
    public GameObject clue;

    private void Start()
    {
        hintTexts = GameObject.FindWithTag("hintTexts");
        GameUI = GameObject.FindWithTag("GameUI");
        clue = GameObject.FindWithTag("clue");
    }
    private void OnMouseDown()
    {
        Debug.Log("�I���@�ɩ�P");

        if (GameUI.GetComponent<eventController>().CheckStatus(1) == true)
        {
            hintTexts.GetComponent<hintTexts>().newText("����j���ж����Ӫ��_��");
            clue.GetComponent<clue>().showClue(1);
            GameUI.GetComponent<toolBoxController>().ShowInToolbox(1);

            GameUI.GetComponent<eventController>().ChangeStatus(0, true);//�c�l�i�H���}
            GameUI.GetComponent<eventController>().ChangeStatus(1, false);//�_�ͨƥ󤣦AĲ�o
        }
        if (GameUI.GetComponent<eventController>().CheckStatus(1) == false)
        {
            hintTexts.GetComponent<hintTexts>().newText("��P�ŤF");
        }
    }
}
