using Photon.Pun;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class charaUI : MonoBehaviourPunCallbacks
{
    /// <summary>
    /// ª±®aID
    /// </summary>
    public static string playerID;

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
        playerID = "1";
        photonView.RPC("DisableButton", RpcTarget.AllBuffered, playerID);
        gameObject.GetComponent<scenesController>().LoadLevel("Ch0_A");
    }
    void Chara2btnOnClick()
    {
        playerID = "2";
        photonView.RPC("DisableButton", RpcTarget.AllBuffered, playerID);
        gameObject.GetComponent<scenesController>().LoadLevel("Ch0_A");
    }
    void BackbtnOnClick()
    {
        gameObject.GetComponent<scenesController>().LoadLevel(0);
    }

    [PunRPC]
    void DisableButton(string playerid)
    {
        chara1Button.interactable = playerid == "1" ? false : true;
        chara2Button.interactable = playerid == "2" ? false : true;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
