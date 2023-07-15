using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class door : MonoBehaviour
{
    GameObject GameUI;

    // Start is called before the first frame update
    void Start()
    {
        GameUI = GameObject.FindWithTag("GameUI");
    }

    private void OnMouseDown()
    {
        if(GameUI.GetComponent<bgController>().getDoorStatus())
        {
            Debug.Log("完成關卡");

            GameUI.GetComponent<scenesController>().LoadLevel(2);
        }
    }
}
