using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class storyTexts : MonoBehaviour
{

    // Start is called before the first frame update
    private void Start()
    {
        GetComponent<Text>().text = "go!";
    }

    int a = 4;
    // Update is called once per frame
    void Update()
    {
        if (a <= 0)
        {
            GetComponent<Text>().text = "congret!";
        }
        else if (Input.GetKeyDown("space"))
        {
            GetComponent<Text>().text = a + "left!";    // �e���[�Ŧr��A�O���F�� ���a �ର �r��C
            a--;
        }
    }
}
