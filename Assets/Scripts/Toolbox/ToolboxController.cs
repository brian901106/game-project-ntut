using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ToolboxController : MonoBehaviour
{
    public GameObject toolsBg;
    public GameObject key;
    GameObject detailObj, toolObj;

    List<GameObject> toolBox = new List<GameObject>();
    int toolCount;

    // Start is called before the first frame update
    void Start()
    {
        toolCount = 0;
        for (int i = 1; i <= 9; i++)
        {
            toolBox.Add(GameObject.Find("b" + i.ToString()));
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ShowInToolbox(string objName)
    {
        detailObj = GameObject.Find(objName+"(Clone)") == null ? null : GameObject.Find(objName+"(Clone)");

        if (detailObj && detailObj.tag == "clonedToolsDetail")
        {
            toolObj = Instantiate(key, toolBox[toolCount].transform.position, Quaternion.identity);
            toolObj.tag = "clonedToolsInBox";
            toolCount++;
        }
    }
}
