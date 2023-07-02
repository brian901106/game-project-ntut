using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class charaUI : MonoBehaviour
{
    public Button chara1Button;
    public Button chara2Button;
    public Button backButton;


    // Start is called before the first frame update
    void Start()
    {
        Button Chara1btn = chara1Button.GetComponent<Button>();
        Chara1btn.onClick.AddListener(Chara1btnOnClick);

        Button Chara2btn = chara2Button.GetComponent<Button>();
        Chara2btn.onClick.AddListener(Chara2btnOnClick);

        Button Backbtn = backButton.GetComponent<Button>();
        Backbtn.onClick.AddListener(BackbtnOnClick);

    }

    void Chara1btnOnClick()
    {
        gameObject.GetComponent<scenesController>().LoadLevel(2);
    }
    void Chara2btnOnClick()
    {
        gameObject.GetComponent<scenesController>().LoadLevel(4);
    }
    void BackbtnOnClick()
    {
        gameObject.GetComponent<scenesController>().LoadLevel(0);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
