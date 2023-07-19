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
    /// 讓手機顯示新資料
    /// (要顯示的字, id = -1時不顯示YNbutton, 字體大小(預設36))
    /// </summary>
    /// <param name="id">
    /// id = -1時不顯示YNbutton,id = 0以上時顯示對應的紙條
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
