using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class drawer_share : MonoBehaviour
{
    public GameObject phoneTexts;

    private void Start()
    {
        phoneTexts = GameObject.FindWithTag("phoneText");
    }
    private void OnMouseDown()
    {
        Debug.Log("�I���@�ɩ�P");

        phoneTexts.GetComponent<phoneTexts>().newText("����j���ж����Ӫ��_��", 36);
        box.can_be_open = true;

    }
}
