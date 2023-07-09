using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class drawer_share : MonoBehaviour
{
    public GameObject phoneTexts;
    public GameObject key;
    public GameObject toolsBg;

    GameObject toolKey = null;

    private void Start()
    {
        phoneTexts = GameObject.FindWithTag("phoneText");
    }
    private void OnMouseDown()
    {
        Debug.Log("點擊共享抽屜");

        phoneTexts.GetComponent<phoneTexts>().newText("收到隔壁房間遞來的鑰匙", 36);
        box.can_be_open = true;

        if (!toolKey)
        {
            Instantiate(key, new Vector3(0, 0, 0), Quaternion.identity);
            toolKey = GameObject.Find("key(Clone)");
            toolKey.transform.localScale = new Vector3(1, 1, 1);
            toolKey.tag = "clonedToolsDetail";
            toolsBg.SetActive(true);
            GameObject.Find("toolBox").GetComponent<ToolboxController>().ShowInToolbox("key");
        }
        else if (!toolKey.activeSelf)
        {
            toolKey.SetActive(true);
            toolsBg.SetActive(true);
        }
    }
}
