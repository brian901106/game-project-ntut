using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moniter : MonoBehaviour
{

    private void Awake()
    {
    }
    private void Start()
    {

    }
    private void OnMouseDown()
    {
        Debug.Log("�I���ù�");

        GameManager.hintTexts.newInput("�o����G�i�H��J�K�X");
        /*
        if (GameObject.FindGameObjectWithTag("passwordInput") == null)
        {
            Instantiate(passwordInputPrefab, GameUI.transform);
            Debug.Log("�I���ù�2");
        }
        */
    }
}
