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
        phoneTexts = GameObject.FindWithTag("hintTexts");
        GameUI = GameObject.FindWithTag("GameUI");
    }
    private void OnMouseUp()
    {
        Debug.Log("�I���ù�");

        phoneTexts.GetComponent<hintTexts>().newText("�o����G�i�H��J�K�X");
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
