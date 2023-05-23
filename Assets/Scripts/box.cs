using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class box : MonoBehaviour
{
    public GameObject phoneTexts;
    public static bool can_be_open;//����令private

    private void Start()
    {
        phoneTexts = GameObject.FindWithTag("phoneText");
        can_be_open = false;
    }
    private void OnMouseDown()
    {
        if (!can_be_open)
        {
            Debug.Log("�I���c�l(�W��)");
            phoneTexts.GetComponent<phoneTexts>().newText("�c�l�Q�W��F�A�W����۱i�ȱ��A�n�\Ū��?", 36, 1);
        }
        if (can_be_open)
        {
            Debug.Log("�I���c�l(����)");
            phoneTexts.GetComponent<phoneTexts>().newText("�̭����ȱ��g�ۤp�r:�ж��K�X=�ⶡ�ж��������ѥ��ƶq", 36);
        }

    }

    public void unlock()
    {
        can_be_open = true;
    }
}
