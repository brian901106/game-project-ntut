using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class prefeb : MonoBehaviour
{
    public int toolId;

    GameObject clue;

    // Start is called before the first frame update
    void Start()
    {
        clue = GameObject.Find("Clue");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    /// <summary>
    /// 按下顯示鑰匙詳細資料
    /// </summary>
    private void OnMouseDown()
    {
        clue.GetComponent<clue>().showClue(toolId);
    }
}
