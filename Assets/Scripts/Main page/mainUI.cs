using Photon.Pun;
using Photon.Realtime;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class mainUI : MonoBehaviourPunCallbacks
{
    public Button startButton;
    public Button settingButton;
    public Button exitButton;

    int roomCount;
    RoomOptions roomOptions = new RoomOptions() { MaxPlayers = 2 };

    MusicPlayer sePlayer;

    // Start is called before the first frame update
    void Start()
    {
        Button Startbtn = startButton.GetComponent<Button>();
        Startbtn.onClick.AddListener(StartbtnOnClick);
        Startbtn.interactable = false;

        Button Settingbtn = settingButton.GetComponent<Button>();
        Settingbtn.onClick.AddListener(SettingbtnOnClick);

        Button Exitbtn = exitButton.GetComponent<Button>();
        Exitbtn.onClick.AddListener(ExitbtnOnClick);

        //連線
        roomCount = 0;
        PhotonNetwork.ConnectUsingSettings();

        //音效、bgm
        sePlayer = GameObject.Find("SoundEffectPlayer").GetComponent<MusicPlayer>();
    }

    void StartbtnOnClick()
    {
        sePlayer.Play("Press");

        //按下start後進入房間，進入房間後才跳轉至選擇角色畫面
        PhotonNetwork.JoinOrCreateRoom("DefaultRoom" + roomCount.ToString(), roomOptions, TypedLobby.Default);
    }
    void SettingbtnOnClick()
    {
        sePlayer.Play("Press");
    }
    void ExitbtnOnClick()
    {
        sePlayer.Play("Press");
    }

    #region CallBacks

    public override void OnConnectedToMaster()
    {
        Debug.Log("Connected to master!");
        PhotonNetwork.JoinLobby();
    }

    public override void OnJoinedLobby()
    {
        Debug.Log("Joined Lobby.");
        startButton.interactable = true;
    }

    public override void OnJoinedRoom()
    {
        Debug.Log("Joined Room.");
        gameObject.GetComponent<scenesController>().LoadLevel("Character");
    }

    public override void OnJoinRoomFailed(short returnCode, string message)
    {
        roomCount++;
        PhotonNetwork.JoinOrCreateRoom("DefaultRoom" + roomCount.ToString(), roomOptions, TypedLobby.Default);
    }

    #endregion

    // Update is called once per frame
    void Update()
    {
        
    }
}
