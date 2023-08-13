using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class linesController : MonoBehaviour
{

    public TextAsset teachA;
    public int nowLine;

    private List<string> textList = new List<string>();

    private void Awake()
    {
        GetTextFormFile(teachA);
        nowLine = 0;
    }
    void GetTextFormFile(TextAsset file)
    {

        textList.Clear();
        var lineData = file.text.Split('\n');

        foreach (var line in lineData) 
        {
            textList.Add(line);
        }
    }

    public string ReadLineFromList()
    {
        string nowLineStr = textList[nowLine];
        if (textList[nowLine] == "end.")
        {
            return "end.";
        }
        return textList[nowLine++]; 
    }
}
