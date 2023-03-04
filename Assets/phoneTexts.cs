using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class phoneTexts : MonoBehaviour
{

    // Start is called before the first frame update
    private void Start()
    {
        GetComponent<Text>().text = "";
    }


    // Update is called once per frame
    void Update()
    {

    }

    public void newText(string newText, int newSize = 48)
    {
        GetComponent<Text>().text = newText;
        GetComponent<Text>().fontSize = newSize;
    }
}
