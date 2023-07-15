using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class bgController : MonoBehaviour
{
    private int bg_num;
    public Button leftButton;
    public Button rightButton;
    public GameObject bg1;
    public GameObject bg2;
    public GameObject bg3;

    public Sprite bg2_door_open;
    public static bool door_is_open;
    // Start is called before the first frame update
    void Start()
    {
        bg_num = 1;

        Button Lbtn = leftButton.GetComponent<Button>();
        Lbtn.onClick.AddListener(LbtnOnClick);

        Button Rbtn = rightButton.GetComponent<Button>();
        Rbtn.onClick.AddListener(RbtnOnClick);

        bg1 = GameObject.FindWithTag("bg1");
        bg2 = GameObject.FindWithTag("bg2");
        bg3 = GameObject.FindWithTag("bg3");

        door_is_open = false;
    }

    void LbtnOnClick()
    {
        bg_num--;
        if (bg_num < 1) { bg_num = 3; }
    }
    void RbtnOnClick()
    {
        bg_num++;
        if (bg_num > 3) { bg_num = 1; }
    }
    // Update is called once per frame
    void Update()
    {
        switch (bg_num)
        {
            case 1:
                bg1.GetComponent<Renderer>().enabled = true;
                bg2.GetComponent<Renderer>().enabled = false;
                bg3.GetComponent<Renderer>().enabled = false;
                bg1.SetActive(true);
                bg2.SetActive(false);
                bg3.SetActive(false);
                break;
            case 2:
                bg1.GetComponent<Renderer>().enabled = false;
                bg2.GetComponent<Renderer>().enabled = true;
                bg3.GetComponent<Renderer>().enabled = false;
                bg1.SetActive(false);
                bg2.SetActive(true);
                bg3.SetActive(false);
                if (door_is_open == true && bg2.GetComponent<SpriteRenderer>().sprite != bg2_door_open)
                    bg2.GetComponent<SpriteRenderer>().sprite = bg2_door_open;
                break;
            case 3:
                bg1.GetComponent<Renderer>().enabled = false;
                bg2.GetComponent<Renderer>().enabled = false;
                bg3.GetComponent<Renderer>().enabled = true;
                bg1.SetActive(false);
                bg2.SetActive(false);
                bg3.SetActive(true);
                break;

        }
    }

    public void opendoor()
    {
        door_is_open = true;
    }

    public bool getDoorStatus()
    {
        return door_is_open;
    }

    public int getBgNum()
    {
        return bg_num;
    }
}
