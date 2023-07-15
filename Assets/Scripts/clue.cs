using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class clue : MonoBehaviour
{
    public GameObject pic;
    public GameObject GameUI;
    public Sprite[] clues;
    private int now_open_id;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void showClue(int id = -1)
    {
        now_open_id = id;
        pic.SetActive(true);
        pic.GetComponent<Image>().sprite = clues[id];
        pic.GetComponent<RectTransform>().sizeDelta = new Vector2(clues[id].rect.width, clues[id].rect.height);
    }
    public void closeClue()
    {
        pic.SetActive(false);
    }
}
