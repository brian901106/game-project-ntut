using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class eventController : MonoBehaviour
{
    GameObject clue;

    bool[] status = new bool[50];//�O���Ҧ��i�����~�����A�Atrue = �i���ʡAfalse = ���i����
    bool[] problem = new bool[50];//�����Ҧ����D�A���D���������ststus�����e

    public string NowOptionName;
    private List<string> NowOptionList = new List<string>();

    // Start is called before the first frame update
    void Start()
    {
        clue = GameObject.FindGameObjectWithTag("clue");

        //��l�]�m
        status[0] = false;    //���ॴ�}box
        status[1] = true;     //�i�H���okey

        //���D��l��
        for (int i = 0; i < 50; i++)
            problem[i] = false;

        NowOptionName = "none";
    }


    /// <summary>
    /// ���i����Ĳ�o�����D
    /// </summary>
    public void SolveProblem(int problem_id)
    {
        switch (problem_id)
        {            
            case 0:
                //�����_��
                status[0] = true;//�c�l�i�H���}
                status[1] = false;//�_�ͤ��AĲ�o
                break;
        }
        problem[problem_id] = true;
    }

    /// <summary>
    /// �i����Ĳ�o���ƥ�A���UYNbutton��Ĳ�o
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
            NowOptionName = "�ӫ���O?(Test)";
            NowOptionList = new List<string>() { "1", "2", "3"};
            gameObject.GetComponent<hintTextsController>().newOption(NowOptionList);
        }
    }

    public void TriggerOption(int num)
    {
        Debug.Log("Ĳ�o�ﶵ:" + num);
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
