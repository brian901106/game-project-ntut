using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moniter : MonoBehaviour
{
    public GameObject phoneTexts;
    public GameObject passwordInputPrefab;
    public GameObject canvas;

    private void Start()
    {
        phoneTexts = GameObject.FindWithTag("phoneText");
    }
    private void OnMouseDown()
    {
        Debug.Log("點擊螢幕");

        phoneTexts.GetComponent<phoneTexts>().newText("這邊似乎可以輸入密碼",36);

        if (GameObject.FindGameObjectWithTag("passwordInput") == null)
        {
            Instantiate(passwordInputPrefab, canvas.transform);
        }

    }
}
