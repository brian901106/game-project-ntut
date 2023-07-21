using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class drawer_share : MonoBehaviour
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
        Debug.Log("�I���@�ɩ�P");

        if (!GameUI.GetComponent<eventController>().CheckIfProblemSolved(0))
        {
            hintTexts.GetComponent<hintTexts>().newText("����j���ж����Ӫ��_��");

            GameUI.GetComponent<itemCreator>().GetTool(0);

            GameUI.GetComponent<eventController>().SolveProblem(0);
        }
        else
        {
            hintTexts.GetComponent<hintTexts>().newText("��P�ŤF");
        }
    }
}
