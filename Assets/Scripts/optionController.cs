
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class optionController : MonoBehaviour
{
    public GameObject option1, option2, option3, option4;
    List<GameObject> OptionGObj = new List<GameObject>();

    public int OptionLength;

    void Start()
    {
        OptionGObj.Add(option1);
        OptionGObj.Add(option2);
        OptionGObj.Add(option3);
        OptionGObj.Add(option4);
    }
    // Start is called before the first frame update
    public void newOption(List<string> option_list)
    {
        int len = option_list.Count;
        OptionLength = len;
        for (int i = 0; i < len; i++)
        {
            OptionGObj[i].SetActive(true);
            OptionGObj[i].transform.GetChild(0).GetComponent<TextMeshProUGUI>().text = option_list[i];
        }
        for (int i = len; i < 4; i++)
        {
            OptionGObj[i].SetActive(false);
        }
    }


    // Update is called once per frame
    void Update()
    {
        
    }
}
