using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class drawer_share : MonoBehaviour
{
    //public GameObject hintTexts;
    //public GameObject GameUI;

    private void Start()
    {
        //hintTexts = GameObject.FindWithTag("hintTexts");
        //GameUI = GameObject.FindWithTag("GameUI");
    }
    private void OnMouseDown()
    {
        Debug.Log("�I���@�ɩ�P");

        if (!GameManager.eventController.CheckIfProblemSolved(0))
        {
            GameManager.hintTexts.newText("����j���ж����Ӫ��_��");

            GameManager.clue.GetTool(0);

            GameManager.eventController.SolveProblem(0);
        }
        else
        {
            GameManager.hintTexts.newText("��P�ŤF");
        }
    }
}
