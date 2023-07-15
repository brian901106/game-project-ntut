using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class passwordInput : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    public int password;
    public GameObject phoneTexts;
    public GameObject GameUI;
    public static bool password_correct;
    public bool isPointerInside;

    // Start is called before the first frame update
    void Start()
    {
        GameUI = GameObject.FindWithTag("GameUI");
        phoneTexts = GameObject.FindWithTag("hintTexts");
        password_correct = false;
    }

    // Update is called once per frame
    void Update()
    {
        if(GetComponent<InputField>().text == "" + password)
        {
            password_correct = true;
            phoneTexts.GetComponent<hintTexts>().newText("門打開了!");
            GameUI.GetComponent<bgController>().opendoor();
        }

    }
    
    public void OnPointerEnter(PointerEventData eventData)
    {
        isPointerInside = true;
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        isPointerInside = false;
    }
    
}
