using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class storyTexts : MonoBehaviour
{
    // Start is called before the first frame update
    private void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (passwordInput.password_correct == true){
            GetComponent<Text>().text = "�ؼ�:�F��\n�q�L���e���U�@��";    // �e���[�Ŧr��A�O���F�� ���a �ର �r��C
        }
    }
}
