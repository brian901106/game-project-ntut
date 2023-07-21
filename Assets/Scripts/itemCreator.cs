using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class itemCreator : MonoBehaviour
{
    public GameObject GameUI;
    public GameObject clue;
    // Start is called before the first frame update
    void Start()
    {
        GameUI = GameObject.FindWithTag("GameUI");
        clue = GameObject.FindWithTag("clue");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void GetTool(int id)
    {
        clue.GetComponent<clue>().ShowTool(id);
        GameUI.GetComponent<toolBoxController>().ShowInToolbox(id);
    }

    public void ShowPaper(int id)
    {
        clue.GetComponent<clue>().ShowPaper(id);
    }
}
