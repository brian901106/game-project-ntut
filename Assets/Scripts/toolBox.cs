using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class toolBox : MonoBehaviour
{
    public int boxId;
    GameObject GameUI;
    // Start is called before the first frame update
    void Start()
    {
        GameUI = GameObject.FindGameObjectWithTag("GameUI");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    /// <summary>
    /// ���U�u����i��GameUI�Q�I�F
    /// </summary>
    private void OnMouseDown()
    {
        GameUI.GetComponent<toolBoxController>().OnMouseDownOnSingleBox(boxId);
    }
}
