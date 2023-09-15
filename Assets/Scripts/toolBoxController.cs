using System.Collections;
using System.Collections.Generic;
using UnityEditor.UIElements;
using UnityEngine;

public class toolBoxController : MonoBehaviour
{
    public GameObject toolBox;
    public GameObject toolPrefab;
    public GameObject clue;
    [SerializeField] GameObject[] boxList;

    GameObject newTool;

    int toolCount;
    int[] toolIdInBox = new int[9];
    Vector3[] toolPosition = new Vector3[9];

    // Start is called before the first frame update
    void Start()
    {
        toolBox = GameObject.FindGameObjectWithTag("toolBox");
        clue = GameObject.FindGameObjectWithTag("clue");
        toolCount = 0;

        //���otoolbox position�A�ΥH�]�w�s�Jtools����m
        for (int n = 0; n < 9; n++)
        {
            toolPosition[n] = boxList[n].transform.position;
            toolIdInBox[n] = -1;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ShowInToolbox(int id)
    {

        newTool = Instantiate(toolPrefab, toolBox.transform, true);
        newTool.GetComponent<Transform>().position = toolPosition[toolCount];
        newTool.GetComponent<SpriteRenderer>().sprite = clue.GetComponent<clue>().GetToolSprite(id);
        newTool.GetComponent<toolPrefab>().SetToolId(id);
        newTool.tag = "clonedToolsInBox";

        toolIdInBox[toolCount] = id;

        toolCount++;
    }


    /// <summary>
    /// �I�U�u��������椺���~
    /// </summary>
    /// <param name="boxId">�u����ID</param>
    public void OnMouseDownOnSingleBox(int boxId)
    {
        clue.GetComponent<clue>().ShowTool(toolIdInBox[boxId]);
    }

}
