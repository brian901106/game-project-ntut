using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class eventController : MonoBehaviour
{
    GameObject clue;

    bool[] status = new bool[50];//記錄所有可互物品的狀態，true = 可互動，false = 不可互動
    bool[] problem = new bool[50];//紀錄所有謎題，謎題完成後改變ststus的內容

    public string NowOptionName;
    private List<string> NowOptionList = new List<string>();

    // Start is called before the first frame update
    void Start()
    {
        clue = GameObject.FindGameObjectWithTag("clue");

        //初始設置
        status[0] = false;    //不能打開box
        status[1] = true;     //可以取得key

        //謎題初始化
        for (int i = 0; i < 50; i++)
            problem[i] = false;

        NowOptionName = "none";
    }


    /// <summary>
    /// 不可重複觸發的謎題
    /// </summary>
    public void SolveProblem(int problem_id)
    {
        switch (problem_id)
        {            
            case 0:
                //拿到鑰匙
                status[0] = true;//箱子可以打開
                status[1] = false;//鑰匙不再觸發
                break;
        }
        problem[problem_id] = true;
    }

    /// <summary>
    /// 可重複觸發的事件，按下YNbutton後觸發
    /// </summary>
    public void TriggerYNEvent(int event_id)
    {
        switch (event_id)
        {
            case 0:
                clue.GetComponent<clue>().ShowPaper(0);
                break;
        }
    }

    public void GenerateOptionByStringID(string option_id)
    {
        Debug.Log("GenerateOptionByStringID:"+ option_id);
        if(option_id == "Test\r")
        {
            NowOptionName = "該怎麼辦呢?(Test)";
            NowOptionList = new List<string>() { "1", "2", "3"};
            gameObject.GetComponent<hintTextsController>().newOption(NowOptionList);
        }
    }

    public void TriggerOption(int num)
    {
        Debug.Log("觸發選項:" + num);
        gameObject.GetComponent<hintTextsController>().Option.SetActive(false);
        gameObject.GetComponent<linesController>().nowLine += 1;
        gameObject.GetComponent<hintTextsController>().nextLine();
    }

    public string GetNowOptionName()
    {
        return NowOptionName;
    }

    public bool CheckIfProblemSolved(int problem_id)
    {
        return problem[problem_id];
    }
}
