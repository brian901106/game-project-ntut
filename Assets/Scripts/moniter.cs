using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moniter : MonoBehaviour
{
    public GameObject phoneTexts;
    public GameObject passwordInputPrefab;
    public GameObject GameUI;

    private void Start()
    {
        phoneTexts = GameObject.FindWithTag("phoneText");
        GameUI = GameObject.FindWithTag("GameUI");
    }
    private void OnMouseUp()
    {
        Debug.Log("�I���ù�");

        phoneTexts.GetComponent<phoneTexts>().newText("�o����G�i�H��J�K�X",36);
        GameUI.GetComponent<inputController>().setInput("��J�K�X...");
        /*
        if (GameObject.FindGameObjectWithTag("passwordInput") == null)
        {
            Instantiate(passwordInputPrefab, GameUI.transform);
            Debug.Log("�I���ù�2");
        }
        */
    }
}
