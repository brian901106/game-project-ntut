using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class clue : MonoBehaviour
{
    public GameObject pic_of_clue;
    // Start is called before the first frame update
    void Start()
    {
        pic_of_clue = GameObject.FindGameObjectWithTag("pic_of_clue");
        pic_of_clue.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void showClue(int id = -1)
    {
        pic_of_clue.SetActive(true);
    }
    public void closeClue()
    {
        pic_of_clue.SetActive(false);
    }
}
