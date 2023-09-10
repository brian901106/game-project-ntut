using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class hintTextsController : MonoBehaviour
{
    public GameObject HintTexts, 
                      Text, 
                      InputSystem, 
                      rBtn, 
                      lBtn, 
                      Avatar, 
                      Option, 
                      showChatBtn,  //��ܲ�ѫǫ��s
                      chatManager,  //��ѫ�
                      toolBox,  //�D����
                      storyText;    //���d�ؼд��ܰT��
    

    bool _lineMode;
    setting set;
    


    // Start is called before the first frame update
    private void Awake()
    {
        HintTexts = GameObject.FindWithTag("hintTexts");
        Text = HintTexts.transform.GetChild(0).gameObject;

        set = this.gameObject.GetComponent<setting>();
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
    /// �������ܷs��r
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
    /// �������ܷs��r�A�X�{YNbutton�A���U��Ĳ�o�]�w�n��Event
    /// </summary>
    /// <param name="id">
    /// YNbutton�A���U��Ĳ�o�]�w�n��Event
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

    public void newOption(List<string> option_list)
    {
        Option.SetActive(true);
        gameObject.GetComponent<optionController>().newOption(option_list);
    }

    private void OnMouseDown()
    {
        Debug.Log("�I���ť�");
        if (set.IsSettingOpen())
        {
            //Do Nothing
        }
        else if (_lineMode)
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

    /// <summary>
    /// �����G�ƼҦ�/�����Ҧ�
    /// </summary>
    /// <param name="mode">true-�G�ƼҦ��Ffalse-�����Ҧ�</param>
    public void ChangeLineMode(bool mode)
    {
        if(mode == true) nextLine();
        _lineMode = mode;
        HintTexts.SetActive(mode);
        Avatar.SetActive(mode);
        rBtn.SetActive(!mode);
        lBtn.SetActive(!mode);
        showChatBtn.SetActive(!mode);
        toolBox.SetActive(!mode);
        storyText.SetActive(!mode);
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

    /// <summary>
    /// ��ܲ�ѫ�
    /// </summary>
    public void ShowChatManager()
    {
        chatManager.SetActive(!chatManager.activeInHierarchy);
    }

}
