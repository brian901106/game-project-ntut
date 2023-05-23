using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class drawer : MonoBehaviour
{
    public GameObject phoneTexts;

    private void Start()
    {
        phoneTexts = GameObject.FindWithTag("phoneText");
    }
    private void OnMouseDown()
    {
        Debug.Log("헕을⒱켗");

        phoneTexts.GetComponent<phoneTexts>().newText("づず⒱켗", 36);

    }
}
