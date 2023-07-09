using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PrefebController : MonoBehaviour
{
    GameObject toolsBg;
    GameObject detailObj;

    // Start is called before the first frame update
    void Start()
    {
        toolsBg = GameObject.Find("toolsBg");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnMouseDown()
    {
        foreach (GameObject item in GameObject.FindGameObjectsWithTag("clonedToolsDetail"))
        {
            if(item.name == this.gameObject.name)
            {
                detailObj = item;
            }
        }
        toolsBg.SetActive(true);
        detailObj.SetActive(true);
        Debug.Log(this.gameObject.name + "pressed.");
    }
}
