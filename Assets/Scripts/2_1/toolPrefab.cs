using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class toolPrefab : MonoBehaviour
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

    public void SetToolId(int id)
    {
        toolId = id;
    }
    /// <summary>
    /// 按下顯示物品詳細資料 (待刪)
    /// </summary>
    private void OnMouseDown()
    {
        clue.GetComponent<clue>().showTool(toolId);
    }
}
