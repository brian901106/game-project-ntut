using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ToolsBgController : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        this.gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnMouseDown()
    {
        this.gameObject.SetActive(false);
        GameObject.FindGameObjectWithTag("clonedToolsDetail").SetActive(false);
    }
}
