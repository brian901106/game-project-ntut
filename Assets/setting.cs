using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class setting : MonoBehaviour
{
    public Button settingBtn;
    public GameObject settingMenu;
    
    // Start is called before the first frame update
    void Start()
    {
        settingMenu.SetActive(false);
        settingBtn.onClick.AddListener(SettingBtnOnClick);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void SettingBtnOnClick()
    {
        settingMenu.SetActive(true);
        Debug.Log("setting pressed.");
    }

    public void BackToHome()
    {
        gameObject.GetComponent<scenesController>().LoadLevel(0);
        Debug.Log("back to home page.");
    }

    public void BackToGame()
    {
        settingMenu.SetActive(false);
        Debug.Log("menu closed.");
    }
}
