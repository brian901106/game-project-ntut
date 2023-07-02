using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class mainUI : MonoBehaviour
{
    public Button startButton;
    public Button settingButton;
    public Button exitButton;


    // Start is called before the first frame update
    void Start()
    {
        Button Startbtn = startButton.GetComponent<Button>();
        Startbtn.onClick.AddListener(StartbtnOnClick);

        Button Settingbtn = settingButton.GetComponent<Button>();
        Settingbtn.onClick.AddListener(SettingbtnOnClick);

        Button Exitbtn = exitButton.GetComponent<Button>();
        Exitbtn.onClick.AddListener(ExitbtnOnClick);

    }

    void StartbtnOnClick()
    {
        gameObject.GetComponent<scenesController>().LoadLevel(1);
    }
    void SettingbtnOnClick()
    {

    }
    void ExitbtnOnClick()
    {

    }
    // Update is called once per frame

    // Update is called once per frame
    void Update()
    {
        
    }
}
