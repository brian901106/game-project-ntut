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
        Debug.Log("點擊共享抽屜");

        phoneTexts.GetComponent<phoneTexts>().newText("收到隔壁房間遞來的鑰匙", 36);
        box.can_be_open = true;

    }
}
