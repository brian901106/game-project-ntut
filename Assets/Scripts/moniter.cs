using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moniter : MonoBehaviour
{
    public GameObject phoneTexts;
    public GameObject passwordInputPrefab;
    public GameObject canvas;

    private void Start()
    {
        phoneTexts = GameObject.FindWithTag("phoneText");
    }
    private void OnMouseDown()
    {
        Debug.Log("�I���ù�");

        phoneTexts.GetComponent<phoneTexts>().newText("�o����G�i�H��J�K�X",36);

        if (GameObject.FindGameObjectWithTag("passwordInput") == null)
        {
            Instantiate(passwordInputPrefab, canvas.transform);
        }

    }
}
