using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class hintTexts : MonoBehaviour
{
    private int hint_id;
    public GameObject GameUI;
    // Start is called before the first frame update
    private void Start()
    {
        GameUI = GameObject.FindWithTag("GameUI");
        GetComponent<Text>().text = "";
        hint_id = 0;
    }


    // Update is called once per frame
    void Update()
    {

    }
    /// <summary>
    /// �������ܷs���
    /// (�n��ܪ��r, id = -1�ɤ����YNbutton, �r��j�p(�w�]36))
    /// </summary>
    /// <param name="id">
    /// id = -1�ɤ����YNbutton,id = 0�H�W����ܹ������ȱ�
    /// </param>
    public void newText(string newText, int id = -1, int newSize = 36)
    {
        hint_id = id;
        if (id == -1)
            GameUI.GetComponent<ynButtonController>().unShowYNButtons();
        else if (id != -1)
            GameUI.GetComponent<ynButtonController>().showYNButtons();
        GetComponent<Text>().text = newText;
        GetComponent<Text>().fontSize = newSize;
    }

    public int getHintId()
    {
        return hint_id;
    }

}
