using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moniter : MonoBehaviour
{
    public GameObject phoneTexts;
    public GameObject passwordInputPrefab;
    public GameObject GameUI;

    private void Start()
    {
        phoneTexts = GameObject.FindWithTag("hintTexts");
        GameUI = GameObject.FindWithTag("GameUI");
    }
    private void OnMouseUp()
    {
        Debug.Log("點擊螢幕");

        phoneTexts.GetComponent<hintTexts>().newText("這邊似乎可以輸入密碼");
        GameUI.GetComponent<inputController>().setInput("輸入密碼...");
        /*
        if (GameObject.FindGameObjectWithTag("passwordInput") == null)
        {
            Instantiate(passwordInputPrefab, GameUI.transform);
            Debug.Log("點擊螢幕2");
        }
        */
    }
}
