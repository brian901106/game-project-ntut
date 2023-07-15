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
            GetComponent<Text>().text = "目標:達成\n通過門前往下一關";    // 前面加空字串，是為了把 整數a 轉為 字串。
        }
    }
}
