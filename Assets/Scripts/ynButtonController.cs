using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ynButtonController : MonoBehaviour
{
    public GameObject yBtn;
    public GameObject nBtn;
    public GameObject hintTexts;
    public GameObject GameUI;

    int event_id;
    // Start is called before the first frame update
    void Start()
    {
        GameUI = GameObject.FindWithTag("GameUI");
        hintTexts = GameObject.FindWithTag("hintTexts");
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
        GameUI.GetComponent<eventController>().TriggerYNEvent(event_id);
    }

    public void noButtonOnClick()
    {
        unShowYNButtons();
        GameUI.GetComponent<hintTextsController>().newText("");
    }

    public void SetEventID(int id)
    {
        event_id = id;
    }
}
