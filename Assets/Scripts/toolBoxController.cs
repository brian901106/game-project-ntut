using System.Collections;
using System.Collections.Generic;
using UnityEditor.UIElements;
using UnityEngine;

public class toolBoxController : MonoBehaviour
{
    public GameObject toolBox;
    public GameObject[] boxes;
    public GameObject key;
    GameObject toolObj;

    int toolCount;
    int[] toolIdInBox = new int[9];
    Vector3[] toolPosition = new Vector3[9];

    // Start is called before the first frame update
    void Start()
    {
        toolBox = GameObject.FindGameObjectWithTag("toolBox");
        toolCount = 0;

        for (int n = 0; n < 9; n++)
        {
            toolPosition[n] = toolBox.transform.GetChild(n).position;
            toolIdInBox[n] = -1;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ShowInToolbox(int id)
    {
        if (id == 1)
        {
            toolIdInBox[toolCount] = key.GetComponent<prefeb>().toolId;
            toolObj = Instantiate(key, toolPosition[toolCount], Quaternion.identity);
            toolObj.tag = "clonedToolsInBox";
        }
        toolCount++;
    }

    /// <summary>
    /// 點下工具欄顯示欄內物品
    /// </summary>
    /// <param name="boxId">工具欄ID</param>
    public void OnMouseDownOnSingleBox(int boxId)
    {
        if (toolIdInBox[boxId] != -1)
        {
            GameObject.Find("Clue").GetComponent<clue>().showClue(toolIdInBox[boxId]);
        }   
    }
}
