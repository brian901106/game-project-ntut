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
        Debug.Log("�I����P");

        phoneTexts.GetComponent<phoneTexts>().newText("�Ū���P", 36);

    }
}
