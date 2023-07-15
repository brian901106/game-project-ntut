using System.Collections;
using System.Collections.Generic;
using UnityEditor.UIElements;
using UnityEngine;

public class toolBoxController : MonoBehaviour
{
    public GameObject toolBox;
    public GameObject key;
    GameObject toolObj;

    int toolCount;
    Vector3[] toolPosition = new Vector3[9];

    // Start is called before the first frame update
    void Start()
    {
        toolBox = GameObject.FindGameObjectWithTag("toolBox");
        toolCount = 0;

        for (int n = 0; n < 9; n++)
        {
            toolPosition[n] = toolBox.transform.GetChild(n).position;
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
            toolObj = Instantiate(key, toolPosition[toolCount], Quaternion.identity);
            toolObj.tag = "clonedToolsInBox";
        }
        toolCount++;
    }
}
