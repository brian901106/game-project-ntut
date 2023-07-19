using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ynButtonController : MonoBehaviour
{
    public GameObject yBtn;
    public GameObject nBtn;
    public GameObject hintTexts;
    public GameObject clue;

    int event_id;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void showYNButtons(int id)
    {
        yBtn.SetActive(true);
        nBtn.SetActive(true);
        event_id = id;
    }
    public void unShowYNButtons()
    {
        yBtn.SetActive(false);
        nBtn.SetActive(false);
    }

    public void yesButtonOnClick()
    {
        clue.GetComponent<clue>().showPaper(event_id);
    }

    public void noButtonOnClick()
    {
        unShowYNButtons();
        hintTexts.GetComponent<hintTexts>().newText("");
    }
}
