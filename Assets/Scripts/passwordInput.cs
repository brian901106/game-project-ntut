using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class passwordInput : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    public int password;
    public GameObject GameUI;
    public static bool password_correct;
    public bool isPointerInside;
    public bool _oneTimeFlag;

    // Start is called before the first frame update
    void Start()
    {
        GameUI = GameObject.FindWithTag("GameUI");
        password_correct = false;
        _oneTimeFlag = false;
    }

    // Update is called once per frame
    void Update()
    {
        if(GetComponent<InputField>().text == "" + password && _oneTimeFlag == false)
        {
            password_correct = true;
            GameUI.GetComponent<hintTextsController>().ChangeTextContent("門打開了!");
            GameUI.GetComponent<bgController>().opendoor();
            _oneTimeFlag = true;
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
