using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class drawer : MonoBehaviour
{
    public GameObject GameUI;

    private void Start()
    {
        GameUI = GameObject.FindWithTag("GameUI");
    }
    private void OnMouseDown()
    {
        Debug.Log("헕을⒱켗");

        GameUI.GetComponent<hintTextsController>().newText("づず⒱켗");

    }
}
