using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class scenesController : MonoBehaviour
{
    public int now_level;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void LoadLevel(int level) 
    {
        now_level = level;
        SceneManager.LoadScene(now_level-1);
    }
}
