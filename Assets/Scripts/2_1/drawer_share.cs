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
        Debug.Log("點擊共享抽屜");

        if (!GameManager.eventController.CheckIfProblemSolved(0))
        {
            GameManager.hintTexts.newText("收到隔壁房間遞來的鑰匙");

            GameManager.clue.GetTool(0);

            GameManager.eventController.SolveProblem(0);
        }
        else
        {
            GameManager.hintTexts.newText("抽屜空了");
        }
    }
}
