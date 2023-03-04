using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class passwordInput : MonoBehaviour
{
    public int password;
    public GameObject phoneTexts;
    public GameObject topRightScene;

    // Start is called before the first frame update
    void Start()
    {
        phoneTexts = GameObject.FindWithTag("phoneText");
        topRightScene = GameObject.FindWithTag("top-right");
    }

    // Update is called once per frame
    void Update()
    {
        if (GetComponent<InputField>().text == "" + password)
        {
            phoneTexts.GetComponent<phoneTexts>().newText("門打開了!");
            topRightScene.GetComponent<topRight>().opendoor();
        }
    }
}
