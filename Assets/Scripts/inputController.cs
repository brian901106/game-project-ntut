using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class inputController : MonoBehaviour
{
    public GameObject inputSystem;

    // Start is called before the first frame update
    void Start()
    {
        
    }


    // Update is called once per frame
    void Update()
    {
        if (inputSystem.activeSelf == true )
        {
            if (Input.GetMouseButtonDown(0) && inputSystem.GetComponent<passwordInput>().isPointerInside == false)
            {
                inputSystem.SetActive(false);
            }
        }

    }

    public void setInput(string text = "")
    {
        inputSystem.SetActive(true);
        inputSystem.GetComponentInChildren<Text>().text = text;
    }
}
