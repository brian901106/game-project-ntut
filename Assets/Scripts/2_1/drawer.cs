using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class drawer : MonoBehaviour
{
    public GameObject phoneTexts;

    private void Start()
    {
        phoneTexts = GameObject.FindWithTag("hintTexts");
    }
    private void OnMouseDown()
    {
        Debug.Log("�I����P");

        phoneTexts.GetComponent<hintTexts>().newText("�Ū���P");

    }
}
