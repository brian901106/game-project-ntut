using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class boxController : MonoBehaviour
{
    public int boxId;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    /// <summary>
    /// 按下工具欄告知GameUI被點了
    /// </summary>
    private void OnMouseDown()
    {
        GameObject.Find("GameUI").GetComponent<toolBoxController>().OnMouseDownOnSingleBox(boxId);
    }
}
