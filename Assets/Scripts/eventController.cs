using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class eventController : MonoBehaviour
{
    GameObject clue;

    bool[] status = new bool[50];//�O���Ҧ��i�����~�����A�Atrue = �i���ʡAfalse = ���i����
    bool[] problem = new bool[50];//�����Ҧ����D�A���D���������ststus�����e
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

    public bool CheckIfProblemSolved(int problem_id)
    {
        return problem[problem_id];
    }
}
