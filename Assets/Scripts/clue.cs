using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class clue : MonoBehaviour
{
    public GameObject pic;
    public GameObject GameUI;
    public Sprite[] papers;
    public Sprite[] tools;
    
    int clue_id;
    int clue_type;


    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void ShowPaper(int id)
    {
        if (papers[id] != null)
        {
            pic.SetActive(true);
            pic.GetComponent<Image>().sprite = papers[id];
            pic.GetComponent<RectTransform>().sizeDelta = new Vector2(papers[id].rect.width, papers[id].rect.height);
            clue_type = 0;
            clue_id = id;
        }
    }

    public void ShowTool(int id)
    {
        if(tools[id] != null)
        {
            pic.SetActive(true);
            pic.GetComponent<Image>().sprite = tools[id];
            pic.GetComponent<RectTransform>().sizeDelta = new Vector2(tools[id].rect.width, tools[id].rect.height);
            clue_type = 1;
            clue_id = id;
        }

    }

    public void GetTool(int id)
    {
        ShowTool(id);
        GameUI.GetComponent<toolBoxController>().ShowInToolbox(0);
    }

    public int GetClueType()
    {
        return clue_type;
    }

    public int GetClueID()
    {
        return clue_id;
    }

    public Sprite GetToolSprite(int id)
    {
        return tools[id];
    }

    public void closeClue()
    {
        pic.SetActive(false);
    }
}
