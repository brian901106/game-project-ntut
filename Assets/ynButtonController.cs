using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ynButtonController : MonoBehaviour
{
    public GameObject yBtn;
    public GameObject nBtn;
    public GameObject phoneTexts;
    public GameObject clue;
    // Start is called before the first frame update
    void Start()
    {
        yBtn = GameObject.FindGameObjectWithTag("yesButton");
        nBtn = GameObject.FindGameObjectWithTag("noButton");
        phoneTexts = GameObject.FindGameObjectWithTag("phoneText");
        clue = GameObject.FindGameObjectWithTag("clue");
        yBtn.SetActive(false);
        nBtn.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void showYNButtons()
    {
        yBtn.SetActive(true);
        nBtn.SetActive(true);
    }
    public void unShowYNButtons()
    {
        yBtn.SetActive(false);
        nBtn.SetActive(false);
    }

    public void yesButtonOnClick()
    {
        int id = phoneTexts.GetComponent<phoneTexts>().getptextid();
        clue.GetComponent<clue>().showClue(id);
    }

    public void noButtonOnClick()
    {
        unShowYNButtons();
        phoneTexts.GetComponent<phoneTexts>().newText("");
    }
}
