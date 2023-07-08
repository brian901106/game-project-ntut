using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class leftrightbuttonhidden : MonoBehaviour
{
    public GameObject leftButton;
    public GameObject rightButton;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (gameObject.GetComponent<bgController>().getBgNum() == 1)
        {
            leftButton.SetActive(true);
            rightButton.SetActive(true);
        }
        if (gameObject.GetComponent<bgController>().getBgNum() == 2)
        {
            leftButton.SetActive(true);
            rightButton.SetActive(false);
        }
        if (gameObject.GetComponent<bgController>().getBgNum() == 3)
        {
            leftButton.SetActive(false);
            rightButton.SetActive(true);
        }
    }
}
