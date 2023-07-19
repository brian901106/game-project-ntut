using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class clue : MonoBehaviour
{
    public GameObject pic;
    public GameObject GameUI;
    public Sprite[] tools;
    public Sprite[] papers;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }


    public void showTool(int id)
    {
        pic.SetActive(true);
        pic.GetComponent<Image>().sprite = tools[id];
        pic.GetComponent<RectTransform>().sizeDelta = new Vector2(tools[id].rect.width, tools[id].rect.height);
    }

    public void showPaper(int id)
    {
        pic.SetActive(true);
        pic.GetComponent<Image>().sprite = papers[id];
        pic.GetComponent<RectTransform>().sizeDelta = new Vector2(papers[id].rect.width, papers[id].rect.height);
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
