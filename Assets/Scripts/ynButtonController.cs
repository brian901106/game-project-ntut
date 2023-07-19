using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ynButtonController : MonoBehaviour
{
    public GameObject yBtn;
    public GameObject nBtn;
    public GameObject hintTexts;
    public GameObject clue;
    // Start is called before the first frame update
    void Start()
    {

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
        int id = hintTexts.GetComponent<hintTexts>().getHintId();
        clue.GetComponent<clue>().showPaper(id);
    }

    public void noButtonOnClick()
    {
        unShowYNButtons();
        hintTexts.GetComponent<hintTexts>().newText("");
    }
}
