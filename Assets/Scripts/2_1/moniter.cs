using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moniter : MonoBehaviour
{

    private void Awake()
    {
    }
    private void Start()
    {

    }
    private void OnMouseDown()
    {
        Debug.Log("點擊螢幕");

        GameManager.hintTexts.newInput("這邊似乎可以輸入密碼");
        /*
        if (GameObject.FindGameObjectWithTag("passwordInput") == null)
        {
            Instantiate(passwordInputPrefab, GameUI.transform);
            Debug.Log("點擊螢幕2");
        }
        */
    }
}
