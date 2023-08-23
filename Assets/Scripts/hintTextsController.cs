using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class hintTextsController : MonoBehaviour
{
    public GameObject HintTexts, Text, InputSystem, yBtn, nBtn, rBtn, lBtn, Avatar;

    bool _lineMode;
    


    // Start is called before the first frame update
    private void Awake()
    {
        HintTexts = GameObject.FindWithTag("hintTexts");
        Text = HintTexts.transform.GetChild(0).gameObject;
    }
    private void Start()
    {
        Text.GetComponent<Text>().text = "";
        HintTexts.SetActive(false);
        ChangeLineMode(true);
    }


    // Update is called once per frame
    void Update()
    {
        
    }
    /// <summary>
    /// 讓手機顯示新文字
    /// </summary>
    public void newText(string newText)
    {
        if (_lineMode)
        {
            nextLine();
        }
        else
        {
            if (HintTexts.activeSelf == false)
            {
                HintTexts.SetActive(true);
                Text.GetComponent<Text>().text = newText;
            }
            else if (!CheckIfClickedInsideInput())
            {
                SetActiveFalse();
            }
        }
    }
    /// <summary>
    /// 讓手機顯示新文字，出現YNbutton，按下後觸發設定好的Event
    /// </summary>
    /// <param name="id">
    /// YNbutton，按下後觸發設定好的Event
    /// </param>
    public void newYN(string newText, int event_id = -1)
    {
        if (_lineMode)
        {
            nextLine();
        }
        else
        {
            if (HintTexts.activeSelf == false)
            {
                HintTexts.SetActive(true);
                gameObject.GetComponent<ynButtonController>().showYNButtons();
                gameObject.GetComponent<ynButtonController>().SetEventID(event_id);
                Text.GetComponent<Text>().text = newText;
            }
            else if (!CheckIfClickedInsideInput())
            {
                SetActiveFalse();
            }
        }

    }

    public void newInput(string newText, int event_id = -1)
    {
        if (_lineMode)
        {
            nextLine();
        }
        else
        {
            if (HintTexts.activeSelf == false)
            {
                HintTexts.SetActive(true);
                InputSystem.SetActive(true);
                Text.GetComponent<Text>().text = newText;
            }
            else if (!CheckIfClickedInsideInput())
            {
                SetActiveFalse();
            }
        }

    }
    private void OnMouseDown()
    {
        Debug.Log("點擊空白");
        if (_lineMode)
        {
            nextLine();
        }
        else
        {
            SetActiveFalse();
        }
    }

    public void nextLine()
    {
        string nowline = gameObject.GetComponent<linesController>().ReadLineFromList();
        if(nowline == "end.")
        {
            ChangeLineMode(false);
        }
        else
        {
            HintTexts.SetActive(true);
            ChangeTextContent(nowline);
        }
        
    }

    public void ChangeLineMode(bool mode)
    {
        if(mode == true) nextLine();
        _lineMode = mode;
        HintTexts.SetActive(mode);
        Avatar.SetActive(mode);
    }

    public void ChangeTextSize(int newSize)
    {
        Text.GetComponent<Text>().fontSize = newSize;
    }

    public void ChangeTextContent(string newText)
    {
        Text.GetComponent<Text>().text = newText;
    }

    void SetActiveFalse()
    {
        gameObject.GetComponent<ynButtonController>().unShowYNButtons();
        InputSystem.SetActive(false);
        HintTexts.SetActive(false);
    }

    bool CheckIfClickedInsideInput()
    {
        if (InputSystem.activeSelf == true && InputSystem.GetComponent<passwordInput>().isPointerInside == true)
            return true;
        return false;
    }
}
