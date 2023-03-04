using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class topRight : MonoBehaviour
{
    public Sprite pic1;
    public Sprite pic2;
    // Start is called before the first frame update
    void Start()
    {
        GetComponent<SpriteRenderer>().sprite = pic1;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void opendoor()
    {
       GetComponent<SpriteRenderer>().sprite = pic2;
    }
}
